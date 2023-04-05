using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public GameObject lightballPrefab;
    private GameObject go;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spell();
        }

    }
    void Spell()
    {
<<<<<<< HEAD
        go = Instantiate(lightballPrefab, lightMagic.position, lightMagic.rotation);
    }
    private void OnBecameInvisible()
    {
        Destroy(go);
=======
        Instantiate(lightballPrefab, gameObject.transform.position, gameObject.transform.rotation);
>>>>>>> 268c0c40a10535beb43bb79ad253d9eec49f9462
    }
}

