using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CameraController cameraController;
    Hotkeys hotkeys;

    Transform hero, heroine;
    Character charHero, charHeroine;

    bool controlled = true;


    // Start is called before the first frame update
    void Start()
    {
        cameraController = GetComponent<CameraController>();
        hotkeys = GetComponent<Hotkeys>();

        charHero = GameObject.Find("Hero").GetComponent<Character>();
        charHeroine = GameObject.Find("Heroine").GetComponent<Character>();

        hero = GameObject.Find("/SCENE/CHARACTERS/Hero/Head").GetComponent<Transform>();
        heroine = GameObject.Find("/SCENE/CHARACTERS/Heroine/Head").GetComponent<Transform>();

        SwapCharacter(); SwapCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        InputListener();
    }

    void InputListener()
    {
        SwapCamera();
        SwapCharacter();
    }

    public void SwapCamera()
    {
        if (Input.GetKeyDown(hotkeys.cameraMode))
        {
            cameraController.firstPerson = !cameraController.firstPerson;

            Vector3 newPos = transform.localPosition;
            if (cameraController.firstPerson) newPos.z = 0f;
            else newPos.z = -cameraController.springArmLenght;


            transform.localPosition = newPos;
        }
    }

    public void SwapCharacter()
    {
        if (Input.GetKeyDown(hotkeys.swapHero))
        {
            if (charHero.possessed)
            {
                charHero.possessed = false;
                charHeroine.possessed = true;
            }
            else
            {
                charHero.possessed = true;
                charHeroine.possessed = false;
            }
            


            switch (controlled)
            {
                case true: cameraController.SwapBody(hero); break;
                case false: cameraController.SwapBody(heroine); break;
            }

            controlled = !controlled;
        }
    }
}
