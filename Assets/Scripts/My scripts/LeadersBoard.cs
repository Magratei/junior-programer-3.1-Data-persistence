using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeadersBoard : MonoBehaviour
{
    private UiManager uiManager;




    public List<Text> texts;

    private void Start()
    {
        uiManager = GameObject.Find("Ui Manager").GetComponent<UiManager>();

        

        for(int i = 0; i < texts.Count; i++)
        {
            if (uiManager.pointLeader[i] != 0)
            {
                texts[i].text = $"{uiManager.nameLeader[i]} - {uiManager.pointLeader[i]}";
                
            }else texts[i].text = "--";
        }
        /*
        Debug.Log($"pointLeader[0] - {pointLeader[0]}");
        Debug.Log($"pointLeader[1] - {pointLeader[1]}");
        Debug.Log($"pointLeader[2] - {pointLeader[2]}");
        Debug.Log($"pointLeader[3] - {pointLeader[3]}");
        Debug.Log($"pointLeader[4] - {pointLeader[4]}");
        */
    }

    public void ButtonMenu()
    {
        SceneManager.LoadScene(0);
    }
}
