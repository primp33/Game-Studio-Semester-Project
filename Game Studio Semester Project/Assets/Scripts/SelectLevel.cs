using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject Boss;
   
    public void LevelSelectmenu()
    {
        level1.SetActive(true);
        level2.SetActive(true);
        level3.SetActive(true);
        Boss.SetActive(true);
    }
    public void Level1menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Level2menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Level3menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Bossmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
}
