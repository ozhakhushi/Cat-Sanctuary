using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private CharacterController character_Controller;

    private Vector3 move_Direction;

    public float speed = 5f;
    private float gravity = 20f;
    public GameObject cam;
    float moveFB, moveLR;	
	float rotHorizontal, rotVertical;
    public float sensitivity = 60.0f;



    public float jump_Force = 10f;
    private float vertical_Velocity;

    void Awake() {
        character_Controller = GetComponent<CharacterController>();
    }
	
	void Update () {

        moveFB = Input.GetAxis ("Horizontal") * speed;
		moveLR = Input.GetAxis ("Vertical") * speed;

		rotHorizontal = Input.GetAxisRaw ("Mouse X") * sensitivity;
		rotVertical = Input.GetAxisRaw ("Mouse Y") * sensitivity;


        MoveThePlayer();
        CameraRotation (cam, rotHorizontal, rotVertical);

	}

    void MoveThePlayer() {

        move_Direction = new Vector3(Input.GetAxis(Axis.HORIZONTAL), 0f,
                                     Input.GetAxis(Axis.VERTICAL));

        move_Direction = transform.TransformDirection(move_Direction);
        move_Direction *= speed * Time.deltaTime;

        ApplyGravity();

        character_Controller.Move(move_Direction);


    } // move player

    void ApplyGravity() {

        vertical_Velocity -= gravity * Time.deltaTime;

        // jump
        PlayerJump();

        move_Direction.y = vertical_Velocity * Time.deltaTime;

    } // apply gravity

    void PlayerJump() {

        if(character_Controller.isGrounded && Input.GetKeyDown(KeyCode.Space)) {
            vertical_Velocity = jump_Force;
        }

    }

    //camera rotation
    void CameraRotation(GameObject cam, float rotHorizontal, float rotVertical){	

			transform.Rotate (0, rotHorizontal * Time.fixedDeltaTime, 0);
			cam.transform.Rotate (-rotVertical * Time.fixedDeltaTime, 0, 0);



			if (Mathf.Abs (cam.transform.localRotation.x) > 0.7) {

				float clamped = 0.7f * Mathf.Sign (cam.transform.localRotation.x); 

				Quaternion adjustedRotation = new Quaternion (clamped, cam.transform.localRotation.y, cam.transform.localRotation.z, cam.transform.localRotation.w);
				cam.transform.localRotation = adjustedRotation;
			}


		}

} // class


































