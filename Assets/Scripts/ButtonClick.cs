using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void OnClickReplay()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void OnClickHome()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void OnClickExit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

