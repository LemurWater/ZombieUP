using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotkeys : MonoBehaviour
{
    [Space(15)]
    [Header("Movement - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode moveFoward = KeyCode.W;
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveBackward = KeyCode.S;
    public KeyCode moveRight = KeyCode.D;
    [Header("Default - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode swapHero = KeyCode.E;
    public KeyCode cameraMode = KeyCode.Mouse2;
    [Header("Character - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode reload = KeyCode.R;
    public KeyCode interact = KeyCode.F;
    public KeyCode primaryFire = KeyCode.Mouse0;
    public KeyCode aim = KeyCode.Mouse1;
    [Header("Special - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")]
    [Space(5)]
    public KeyCode dash = KeyCode.LeftShift;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
