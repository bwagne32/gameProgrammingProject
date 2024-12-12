using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public float moveSpeed = 50f;
    public Camera camera;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = Camera.main.transform.position;


        float horizontalInput = 0;
        float verticalInput = 0;
        //float zoomLevel = 0;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && cameraPosition.x > -13f)
        {
            horizontalInput = -1;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && cameraPosition.x < 19f)
        {
            horizontalInput = 1;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && cameraPosition.y < 21)
        {
            verticalInput = 1;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && cameraPosition.y > -6f)
        {
            verticalInput = -1;
        }
        else if (Input.GetKeyDown(KeyCode.PageDown) && camera.orthographicSize < 14) // zoom out
        {
            camera.orthographicSize += 2;
        }
        else if (Input.GetKeyDown(KeyCode.PageUp) && camera.orthographicSize > 4) // zoom in
        {
            camera.orthographicSize -= 2;
        }


        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * camera.orthographicSize * Time.deltaTime;

        transform.Translate(movement);
    }
}
