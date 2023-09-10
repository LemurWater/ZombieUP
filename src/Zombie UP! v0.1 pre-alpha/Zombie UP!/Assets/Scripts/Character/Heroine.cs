using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroine : Character
{
    [Space(20)]
    [Header("Heroine")]
    public byte stamina;
    public byte staminaMax;


    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
}
