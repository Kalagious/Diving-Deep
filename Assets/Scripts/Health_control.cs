using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health_control : MonoBehaviour
{
    Slider slide;

    public AudioSource audio;

    float health=100;

    // Start is called before the first frame update
    void Start()
    {
        slide=GetComponent<Slider>();
    }

    // Take damage
    public void TakeDamage(float dmg)
    {
        health -= dmg;
        audio.Play();

        if (health <= 0) { // Once damage dealing mechanism exists, need to test
            SceneManager.LoadScene("EndScreen");
        } else {
            slide.value = health;
        }   
    }
}
