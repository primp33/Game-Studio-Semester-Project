using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{
    public int level = 1;
    public float currentXp = 0;
    public float requiredXp;

    //private float lerpTimer;
    //private float delayTimer;
    [Header("UI")]
    //public Image frontXpBar;
    //public Image backXpBar;
    //private GameObject front;
    //private GameObject back;
    public GameObject slider1;
    private Slider slider;
    public GameObject dontdestory;

    // Start is called before the first frame update
    void Start()
    {
        dontdestory = GameObject.Find("DontDestroy");
        //front = GameObject.Find("Fill");
        //back = GameObject.Find("Background");
        slider1 = GameObject.Find("expBar");
        slider = slider1.GetComponent<Slider>();
        //frontXpBar = front.GetComponent<Image>();
        //backXpBar = back.GetComponent<Image>();
        requiredXp = 60;
        DontDestroyOnLoad(this.gameObject);
        //frontXpBar.fillAmount = currentXp / requiredXp;
        //backXpBar.fillAmount = currentXp / requiredXp;
    }

    // Update is called once per frame
    void Update()
    {
        if (dontdestory != null)
        {
            Destroy(this.gameObject);
        }
        slider1 = GameObject.Find("expBar");
        if (slider1 != null)
        {
        slider = slider1.GetComponent<Slider>();
        slider.value = currentXp / requiredXp;
        //UpdateXpUI();
        //if (Input.GetKeyDown(KeyCode.Equals))
        //    GainExperienceFlatRate(20);
        }
        if (currentXp >= requiredXp)
            LevelUp();
    }

    public void LevelUp()
    {
        currentXp = Mathf.RoundToInt(currentXp - requiredXp);
        level++;
        requiredXp += 200;
    }
}