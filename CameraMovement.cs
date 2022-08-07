using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CameraMovement : MonoBehaviour
{
    Transform t_Camera; // Camera Controller
    Camera c_Camera; // Camera
    Transform t_Player; // Player
    BoxCollider2D c_Barrier; // Collider
    [Header("Camera Options")]
    [SerializeField][Tooltip("The Offset On The X Axis")]
    private float x_Offset = 0f;
    [SerializeField][Tooltip("The Scale Of Camera Smoothing")]
    private float cameraScale = 1f;

    void Awake() {
        t_Camera = this.transform;
        c_Camera = Camera.main;
        t_Player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        c_Barrier = this.GetComponent<BoxCollider2D>();
        Vector2 v_CameraSize = c_Camera.ScreenToWorldPoint(new Vector2(c_Camera.pixelWidth,c_Camera.pixelHeight));
        c_Barrier.size = new Vector2(0.1f,v_CameraSize.y * 2);
        c_Barrier.offset = new Vector2(-v_CameraSize.x,0);
    }

    void FixedUpdate() {
        float x_Camera = t_Camera.position.x;
        float x_Player = t_Player.position.x;
        if(x_Player > x_Camera - x_Offset) t_Camera.position = Vector3.Lerp(t_Camera.position, new Vector3(x_Player, t_Camera.position.y, -10), Time.fixedDeltaTime * cameraScale);
    }
}
