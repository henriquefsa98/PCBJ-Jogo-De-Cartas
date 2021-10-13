using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menu : MonoBehaviour
{
    public string cena;

    public GameObject optionsPanel;

    public void StartGame()
    {
        PlayerPrefs.SetInt("gameMode", 0);
        SceneManager.LoadScene("Lab3");
    }

    public void StartRedGame()
    {
        PlayerPrefs.SetInt("gameMode", 1);
        SceneManager.LoadScene("Lab3");
    }

    public void StartBigGame()
    {
        PlayerPrefs.SetInt("gameMode", 2);
        SceneManager.LoadScene("Lab3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowOptions()
    {
       optionsPanel.SetActive(true);

    }
    public void BackToMenu()
    {
optionsPanel.SetActive(false); 

    }

}
 