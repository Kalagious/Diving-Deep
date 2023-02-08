using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chests : MonoBehaviour
{
    private GameManager gmGameManager;
    private bool bIsOpened;
    private Animator aAnimator;
    // Start is called before the first frame update
    void Start()
    {
        bIsOpened = false;
        gmGameManager = GameObject.FindObjectOfType<GameManager>();
        aAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!bIsOpened)
        {
            gmGameManager.AddScore(1);
            aAnimator.SetTrigger("Open");
            bIsOpened = true;
        }
    }
}
