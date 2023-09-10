using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Control")]
    public bool canRotate = true;
    [Space(20)]

    public float sensitivity;
    [Space(20)]
    public Transform body;

    float xRotation = 0f;


    Transform springArm;

    public GameObject chra;

    public bool firstPerson = false;
    public float springArmLenght = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        springArm = GameObject.Find("Spring Arm").GetComponent<Transform>();

        Follow();
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
        Rotate();
    }

    public void Follow()
    {
        springArm.position = body.position;
    }
    public void Rotate()
    {
        if(canRotate)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.parent.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            transform.parent.Rotate(Vector3.up * mouseX);
            body.parent.transform.Rotate(Vector3.up * mouseX);
        }
    }

    public void SwapBody(Transform newBody)
    {
        body = newBody;
        springArm.SetParent(newBody.transform.parent);
    }
}
