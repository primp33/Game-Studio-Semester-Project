using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class levelSystem : MonoBehaviour
{
    public int level;
    public float currentXp;
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

    // Start is called before the first frame update
    void Start()
    {
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
        slider1 = GameObject.Find("expBar");
        slider = slider1.GetComponent<Slider>();
        slider.value = currentXp / requiredXp;
        //UpdateXpUI();
        //if (Input.GetKeyDown(KeyCode.Equals))
        //    GainExperienceFlatRate(20);
        if (currentXp >= requiredXp)
            LevelUp();
    }

    //public void UpdateXpUI()
    //{
    //    float xpfraction = currentXp / requiredXp;
    //    float FXP = frontXpBar.fillAmount; 
    //    if (FXP < xpfraction)
    //    {
    //        delayTimer += Time.deltaTime;
    //        backXpBar.fillAmount = xpfraction;
    //        if (delayTimer > 3)
    //        {
    //            lerpTimer += Time.deltaTime;
    //            float percentComplete = lerpTimer / 4;
    //            frontXpBar.fillAmount = Mathf.Lerp(FXP, backXpBar.fillAmount, percentComplete);
    //        }
    //    }
    //}
    //public void GainExperienceFlatRate(float xpGained)
    //{
    //    currentXp += xpGained;
    //    lerpTimer = 0f;
    //}
    public void LevelUp()
    {
        currentXp = Mathf.RoundToInt(currentXp - requiredXp);
        level++;
        //frontXpBar.fillAmount = 0f;
        //backXpBar.fillAmount = 0f;
        requiredXp += 200;
    }
}
