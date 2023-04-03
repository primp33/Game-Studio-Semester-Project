using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public Transform lightMagic;
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
        Instantiate(lightballPrefab, lightMagic.position, lightMagic.rotation);
    }
}

