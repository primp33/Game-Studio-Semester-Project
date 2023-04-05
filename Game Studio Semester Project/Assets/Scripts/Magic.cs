using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public GameObject lightballPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spell();
        }

    }
    void Spell()
    {
        if(nearest_monster == player)
        {
            Instantiate(lightballPrefab, gameObject.transform.position, gameObject.transform.rotation);
        }
        else if (nearest_monster == false)
        {
            Instantiate(lightballPrefab, gameObject.transform.position, gameObject.transform.rotation);
        }
        else if()
        {
            Instantiate(lightballPrefab, nearest_distance.transform.position, nearest_distance.transform.rotation);
        }
    }
}

