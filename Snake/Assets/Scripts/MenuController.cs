using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject creditosPanel;

    public void BackMenu(){
        SceneManager.LoadScene("Menu");
    }
    public void PlayGame(){
        SceneManager.LoadScene("Jogo");
    }
    public void Exit(){
        Application.Quit();
    }
    public void Creditos(){
        creditosPanel.SetActive(!creditosPanel.activeSelf);
    }
}
