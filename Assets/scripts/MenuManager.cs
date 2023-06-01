using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string nameLevelGame;
    [SerializeField] private GameObject painelMenuInitial;
    [SerializeField] private GameObject painelOptions;

    public void Play()
    {
        SceneManager.LoadScene(nameLevelGame);
    }
    public void OpenOptions()
    {
        painelMenuInitial.SetActive(false);
        painelOptions.SetActive(true);
    }
    public void LeaveOptions()
    {
        painelOptions.SetActive(false);
        painelMenuInitial.SetActive(true);
    }
    public void LeaveGame()
    {
        Debug.Log("Sair");
        Application.Quit();
    }
}
