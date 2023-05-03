using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStates : MonoBehaviour
{
    public int level;

    public int currExp;
    public int maxExp;

    public Slider expBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSliderUI()
    {
        expBar.value = currExp;

        expBar.maxValue = maxExp;
    }
}
