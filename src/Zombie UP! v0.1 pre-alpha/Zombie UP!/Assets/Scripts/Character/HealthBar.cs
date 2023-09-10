using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image fill, back;
    public float currentHealth;
    public float maxHealth = 100f;


    // Start is called before the first frame update
    void Start()
    {
        UpdateBar(0.69f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateBar(float value)
    {
        fill.fillAmount = value;
    }
}
