using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private void Start()
    {
        SaveGame(10, 20);
        LoadGame();
    }
    private void SaveGame(int viewers, int money)
    {
        PlayerData playerData = new PlayerData();
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(Application.dataPath + "/saveFile.json", json);
    }
    private void LoadGame()
    {
        string json = File.ReadAllText(Application.dataPath + "/saveFile.json");
        PlayerData loadData = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log(loadData.Money);
        Debug.Log(loadData.Viewers);
    }
    public static class SaveSystem
    {
        public static void SaveGameValues()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/player.values";
            FileStream stream = new FileStream(path, FileMode.Create);

            PlayerData data = new PlayerData();

            formatter.Serialize(stream, data);
            stream.Close();
        }
    }
}
