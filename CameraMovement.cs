using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CameraMover : MonoBehaviour
{
    Transform t_Camera; // Camera Controller (To Move)
    Camera c_Camera; // Camera (For Size)
    Transform t_Player; // Player (For Position)
    BoxCollider2D c_Barrier; // Collider (To Keep Player From Exiting)

    [Header("Camera Options")]
    [SerializeField][Tooltip("The Offset On The X Axis")]
    private float x_Offset = 0f; // How Much The Camera Should Be Offset On The X Axis

    void Start() {
      t_Camera = this.transform; // Sets Camera Controller
      c_Camera = Camera.main; // Sets Camera
      t_Player = GameObject.FindGameObjectsWithTag("Player")[0].transform; // Sets Player
      c_Barrier = this.GetComponent<BoxCollider2D>(); // Sets Collider

      Vector2 v_CameraSize = c_Camera.ScreenToWorldPoint(new Vector2(c_Camera.pixelWidth,c_Camera.pixelHeight)); // Finds Camera Size In World Space

      c_Barrier.size = new Vector2(0.1f,v_CameraSize.y * 2); // Sets Height Of Barrier To Height Of Camera
      c_Barrier.offset = new Vector2(-v_CameraSize.x,0); // Sets Barrier To Left Side Of Camera
    }

    void Update() {
      float x_Camera = t_Camera.position.x; // Finds Camera Position
      float x_Player = t_Player.position.x; // Finds Player Position
      if(x_Player > x_Camera - x_Offset) t_Camera.position = new Vector2(x_Player + x_Offset, t_Camera.position.y); // Moves Camera

    }

}
