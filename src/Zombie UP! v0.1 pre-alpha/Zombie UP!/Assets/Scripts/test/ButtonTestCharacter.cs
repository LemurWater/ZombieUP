using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ButtonTestCharacter : MonoBehaviour
{
    Character hero, heroine;

    public Player playerScript;


    
    // Start is called before the first frame update
    void Start()
    {
        hero = GameObject.Find("Hero").GetComponent<Character>();
        heroine = GameObject.Find("Heroine").GetComponent<Character>();
    }

    public void Clicked()
    {
        playerScript.SwapCharacter();
        
    }
}
