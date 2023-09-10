using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public bool possessed = false;
    [Space(5)]
    public float health, healthMax;
    public float speed;


    internal CharacterController controller;


    // Start is called before the first frame update


    public void Movement()
    {
        if(possessed)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);
        }
        else
        {
            //AI movement
        }
    }
}
