using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform player;
    public Transform camera;

    public float xOffset = 0;

    float xCamera;
    float xPlayer;

    void FixedUpdate()
    {

        xCamera = camera.position.x;
        xPlayer = player.position.x;

        if (xPlayer > xCamera - xOffset)
        {
            camera.position = new Vector2(xPlayer + xOffset, camera.position.y);
        }
        else
        {
            camera.position = new Vector2(xCamera, camera.position.y);
        }

    }
}
