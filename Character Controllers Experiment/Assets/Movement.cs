
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float speed = 10f;
    private float gravity = -9.81f;
    private float jumpSpeed = 50f;
    private Vector3 position;
    public CharacterController controller;
    
    void Update()
    {
        position.x = speed*Input.GetAxis("Horizontal");;

        if (!controller.isGrounded)
        {
            position.y += gravity;
        }

        if (Input.GetButtonDown("Jump"))
        {
            position.y = jumpSpeed;
        }
        
        controller.Move(position*Time.deltaTime);
        
    }
}
