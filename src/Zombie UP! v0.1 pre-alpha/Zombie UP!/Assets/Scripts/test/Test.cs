using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Player player;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;


        player = GameObject.Find("Camera").GetComponent<Player>();
        player.SwapCharacter(); player.SwapCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
