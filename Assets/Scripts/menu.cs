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
 