using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supCam : MonoBehaviour
{

    public focusLevel FocusLevel;
    public List<GameObject> Players;

    public float depthUpdateSpeed = 5f;
    public float angleUpdateSpeed = 7f;
    public float positionUpdateSpeed = 5f;

    public float depthMax = -10f;
    public float depthMin = -22f;

    public float angleMax = 11f;
    public float angleMin = 3f;

    private float cameraEulerX;
    private Vector3 cameraPosition;


	// Use this for initialization
	void Start ()
    {
        Players.Add(FocusLevel.gameObject);
	}
	
	// Update is called once per frame
	private void LateUpdate ()
    {
        calculateCameraLocations();
        moveCamera();
	}

    private void moveCamera()
    {
        Vector3 position = gameObject.transform.position;
        if (position != cameraPosition)
        {
            Vector3 targetPosition = Vector3.zero;
            targetPosition.x = Mathf.MoveTowards(position.x, cameraPosition.x, positionUpdateSpeed * Time.deltaTime);
            targetPosition.y = Mathf.MoveTowards(position.y, cameraPosition.y, positionUpdateSpeed * Time.deltaTime);
            targetPosition.z = Mathf.MoveTowards(position.z, cameraPosition.z, depthUpdateSpeed * Time.deltaTime);
            gameObject.transform.position = targetPosition;

        }

        Vector3 localEulerAngles = gameObject.transform.localEulerAngles;
        if (localEulerAngles.x != cameraEulerX)
        {
            Vector3 targetEulerAngles = new Vector3(cameraEulerX, localEulerAngles.y, localEulerAngles.z);
            gameObject.transform.localEulerAngles = Vector3.MoveTowards(localEulerAngles, targetEulerAngles, angleUpdateSpeed * Time.deltaTime);
        }
    }

    private void calculateCameraLocations()
    {
        Vector3 averageCenter = Vector3.zero;
        Vector3 totalPositions = Vector3.zero;
        Bounds playerBounds = new Bounds();

        for (int i = 0; i < Players.Count; i++)
        {
            Vector3 playerPosition = Players[i].transform.position;

            if (!FocusLevel.FocusBounds.Contains(playerPosition))
            {
                float playerX = Mathf.Clamp(playerPosition.x, FocusLevel.FocusBounds.min.x, FocusLevel.FocusBounds.max.x);
                float playerY = Mathf.Clamp(playerPosition.y, FocusLevel.FocusBounds.min.y, FocusLevel.FocusBounds.max.y);
                float playerZ = Mathf.Clamp(playerPosition.z, FocusLevel.FocusBounds.min.z, FocusLevel.FocusBounds.max.z);
                playerPosition = new Vector3(playerX, playerY, playerZ);
            }

            totalPositions += playerPosition;
            playerBounds.Encapsulate(playerPosition);

        }

        averageCenter = (totalPositions / Players.Count);

        float extents = (playerBounds.extents.x + playerBounds.extents.y);
        float lerpPercent = Mathf.InverseLerp(0, (FocusLevel.HalfXBounds + FocusLevel.HalfYBounds) / 2, extents);

        float depth = Mathf.Lerp(depthMax, depthMin, lerpPercent);
        float angle = Mathf.Lerp(angleMax, angleMin, lerpPercent);

        cameraEulerX = angle;
        cameraPosition = new Vector3(averageCenter.x, averageCenter.y, depth);
    }
}
