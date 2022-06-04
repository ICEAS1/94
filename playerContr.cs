using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerContr : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerBody;
    public CharacterController contr;
    int hp=10;
    

    public float speed=12f;
    float xRotation=0f;

    //public Gravity grav;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X");
        float mouseY=Input.GetAxis("Mouse Y");

        playerBody.Rotate(0,mouseX,0);

        float vertical=Input.GetAxis("Vertical");
        float horizontal=Input.GetAxis("Horizontal");

        contr.Move(playerBody.forward*vertical*speed*Time.deltaTime);
        contr.Move(playerBody.right*horizontal*speed*Time.deltaTime);

        xRotation=xRotation-mouseY;
        xRotation=Math.Clamp(xRotation,-90,90);
        transform.localRotation=Quaternion.Euler(xRotation,0,0);
        playerBody.Rotate(0,mouseX,0);

        contr.Move(playerBody.right*speed*horizontal*Time.deltaTime);
        if(playerBody.tag=="enemy"){
            hp=hp-1;
        }
    }

}
