using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public class UiManager : MonoBehaviour
{
    public static UiManager Instance;
    public string nameGamer;
    public string nameLast;
    public int pointLast = 0;
    public string nameBest = "NoName";
    public int pointBest = 0;

    public int[] pointLeader = new int[5];
    public string[] nameLeader = new string[5];


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadData();
    }
    //расставляет по местам лидеров игры в зависимости от их очков
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
            pointLeader[0] = pointBest;
            nameLeader[0] = nameBest;
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
        SaveProcess();
    }


    [System.Serializable]
    class SaveData
    {
        public int[] pointLeader = new int[5];
        public string[] nameLeader = new string[5];
    }

    public void SaveProcess()
    {
        SaveData data = new SaveData();
        data.pointLeader = pointLeader;
        data.nameLeader = nameLeader;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            pointLeader = data.pointLeader;
            nameLeader = data.nameLeader;

        }
    }



}
