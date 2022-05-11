using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Bridge : MonoBehaviour
{
    public static string Name;
    public static string HighScoreName;
    public static int HighScore;

    class SaveBridgeData
    {

        public string name;
        public int Highscore;


    }
    public static void LoadScoreData( )
    {


        string path = Application.persistentDataPath + "/savezzfile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveBridgeData data = JsonUtility.FromJson<SaveBridgeData>(json);
            HighScoreName = data.name;
            HighScore = data.Highscore;
        }
    }


}
