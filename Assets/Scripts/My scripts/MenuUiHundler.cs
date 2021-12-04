using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUiHundler : MonoBehaviour
{
    public InputField input;
    public bool startGame = false;
    private UiManager uiManager;

    private void Start()
    {
        uiManager = GameObject.Find("Ui Manager").GetComponent<UiManager>();
        
    }

    public void StartNew()
    {
        startGame = true;
        if (input.text != "") uiManager.nameGamer = input.text;
        else uiManager.nameGamer = "NoName";
        SceneManager.LoadScene(1); 
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit();
        #endif
    }

}
