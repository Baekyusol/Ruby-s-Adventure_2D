using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject menuSet;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(menuSet.activeSelf)
            {
                menuSet.SetActive(false);
            }
            else
                menuSet.SetActive(true);
        }
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
