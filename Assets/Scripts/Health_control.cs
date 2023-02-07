using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_control : MonoBehaviour
{
    Slider slide;

    float health=100;
    // Start is called before the first frame update
    void Start()
    {
        slide=GetComponent<Slider>();
    }

    //Take damage
    public void TakeDamage(float dmg)
    {
        health -= dmg;
        slide.value = health;
    }
}
