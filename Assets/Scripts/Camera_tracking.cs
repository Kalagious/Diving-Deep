using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_tracking : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private Vector2 threshold;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        threshold = new Vector2(3, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > transform.position.x+threshold.x)
            transform.position = new Vector3(player.transform.position.x-threshold.x, transform.position.y, -10);
        else if (player.transform.position.x < transform.position.x - threshold.x)
            transform.position = new Vector3(player.transform.position.x + threshold.x, transform.position.y, -10);

        if (player.transform.position.y > transform.position.y + threshold.y)
            transform.position = new Vector3(transform.position.x, player.transform.position.y - threshold.y, -10);
        else if (player.transform.position.y < transform.position.y - threshold.y)
            transform.position = new Vector3(transform.position.x, player.transform.position.y + threshold.y, -10);
    }
}
