using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.UI;


public class HUD : MonoBehaviour
{
    SystemController system;
    TMP_Text build;

    // Start is called before the first frame update
    void Start()
    {
        Version();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Version()
    {
        system = GameObject.Find("SYSTEM").GetComponent<SystemController>();
        build = GameObject.Find("/HUD/Build").GetComponent<TMP_Text>();

        build.text = system.name + " ... version " + system.version;
    }
}
