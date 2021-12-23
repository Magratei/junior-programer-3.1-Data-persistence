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
    public Text bestText;
    //private UiManager uiManager;


    private void Start()
    {
        //uiManager = GameObject.Find("Ui Manager").GetComponent<UiManager>();

        bestText.text = $"Best Score: {UiManager.Instance.nameBest} : {UiManager.Instance.pointBest}";
        
        
    }

    public void StartNew()
    {
        
        if (input.text != "") UiManager.Instance.nameGamer = input.text;
        else UiManager.Instance.nameGamer = "NoName";
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

    public void LeadersButton()
    {
        SceneManager.LoadScene(2);
    }


}
