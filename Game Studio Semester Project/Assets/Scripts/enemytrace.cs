using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemytrace : MonoBehaviour
{
    private GameObject player;
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");
        enemy = gameObject;
        float distance = Mathf.Pow(player.transform.position.x - enemy.transform.position.x,2) + Mathf.Pow(player.transform.position.y - enemy.transform.position.y,2);
        if (distance >= player.GetComponent<state>.nearest_distance)
        {
            player.GetComponent<state>.nearest_moster = enemy;
            player.GetComponent<state>.nearest_distance = distance;
        }
    }
}
