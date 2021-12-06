using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UiManager : MonoBehaviour
{
    private static UiManager uiManager;
    public string nameGamer;
    public string nameBest = "NoName";
    public int pointBest = 0;
    

    private void Awake()
    {
        if (uiManager != null)
        {
            Destroy(gameObject);
            return;
        }

        uiManager = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
       // Debug.Log(nameGamer);
    }


}
