using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchInventory : MonoBehaviour
{
    public Magic magic;
    public GameObject[] torches;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        magic.torch = count;
    }

    // Update is called once per frame
    void Update()
    {
        if (magic.torch != count)
        {
            torches[magic.torch-1].SetActive(false);
            count = magic.torch;
        }
    }
}
