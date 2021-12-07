using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UiManager : MonoBehaviour
{
    private static UiManager uiManager;
    public string nameGamer;
    public string nameLast;
    public int pointLast = 0;
    public string nameBest = "NoName";
    public int pointBest = 0;

    public int[] pointLeader = new int[5];
    public string[] nameLeader = new string[5];


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

    public void LeadersGame()
    {
        if (pointBest > pointLeader[0])
        {
            for (int i = 4; i > 0; i--)
            {
                pointLeader[i] = pointLeader[i - 1];
                Debug.Log($"pointLeader[{i}] - {pointLeader[i]}");
                nameLeader[i] = nameLeader[i - 1];
            }
            pointLeader[0] = uiManager.pointBest;
            nameLeader[0] = uiManager.nameBest;
        }else
        {
            for (int i = 0; i < 5; i++)
            {
                if (pointLast > pointLeader[i] && pointLeader[i] != 0)
                {
                    for(int o = 4; o > i; o--)
                    {
                        pointLeader[o] = pointLeader[o - 1];
                        nameLeader[o] = nameLeader[o - 1];
                    }
                    pointLeader[i] = pointLast;
                    nameLeader[i] = nameLast;
                    break;
                }
            }
        }
    }

    private void Update()
    {
       // Debug.Log(nameGamer);
    }


}
