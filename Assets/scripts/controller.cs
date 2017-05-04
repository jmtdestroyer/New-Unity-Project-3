using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    //sätter publika variabler
    public float movementSpeed, mouseSpeed, rotationUppNer, lasvinkel, acceleration, JumpForce;
     
    // Use this for initialization
    void Start()
    {
    }


    // Update is called once per frame
    void Update() {
        //hämtar och döper character controller
        CharacterController cc = GetComponent<CharacterController>();

        //rotera kameran höger vänster
        float rotationHogerVanster = Input.GetAxis("Mouse X") * mouseSpeed;
        transform.Rotate(0, rotationHogerVanster, 0);




        //rotera kamera upp ner
        rotationUppNer -= Input.GetAxis("Mouse Y") * mouseSpeed;
        rotationUppNer = Mathf.Clamp(rotationUppNer, -lasvinkel, lasvinkel);
        Camera.main.transform.localRotation = Quaternion.Euler(rotationUppNer,0,0);

        //uppdaterings variabler
        float speedForward = Input.GetAxis("Vertical")*movementSpeed;
        float speedSideStep = Input.GetAxis("Horizontal")*movementSpeed;
        acceleration += Physics.gravity.y * Time.deltaTime;
        Vector3 speed = new Vector3(speedSideStep, acceleration, speedForward);

        //Hoppa
        
        acceleration += Physics.gravity.y * Time.deltaTime;

        if (cc.isGrounded && Input.GetKeyDown ("space"))
        {
            acceleration = JumpForce;
        }
        
        
        //rotation adderar till speed
        speed = transform.rotation * speed;
        cc.Move(speed * Time.deltaTime);
        //kontrolla knapp
		
        }
    }