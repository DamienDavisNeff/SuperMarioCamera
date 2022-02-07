using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject player;
    public GameObject camera;

    public float xOffset = 0;

    float xCamera;
    float yCamera;
    float xPlayer;

    // Update is called once per frame
    void Update()
    {

        xCamera = camera.transform.position.x;
        yCamera = camera.transform.position.y;
        xPlayer = player.transform.position.x;

        if(xPlayer>xCamera-xOffset)
        {
            camera.transform.position = new Vector2(xPlayer + xOffset, yCamera);
        } else
        {
            camera.transform.position = new Vector2(xCamera, yCamera);
        }
        
    }
}
