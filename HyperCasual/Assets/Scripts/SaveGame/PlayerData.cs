using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

class PlayerData : MonoBehaviour
{
    static public PlayerData Instance;
    [SerializeField] int viewers;
    [SerializeField] int money;
    public int Viewers { get { return viewers; } }
    public int Money { get { return money; } }


    public Action<int> ChangeData;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Load();
        }
        else if (Instance == this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);
    }
    IEnumerator Start()
    {
        yield return null;
        ChangeData?.Invoke(viewers);
    }
    public void ChangeViewers(int viewers)
    {
        this.viewers += viewers;
        Save();
    }
    public void ChangeMoney(int money)
    {
        this.money += money;
        Save();
    }
    void Save()
    {
        string key = "MyGame";

        SaveData data = new SaveData();
        data.Viewers = Viewers;
        data.Money = Money;


        string value = JsonUtility.ToJson(data);

        PlayerPrefs.SetString(key, value);

        PlayerPrefs.Save();

        ChangeData?.Invoke(25);
    }
    void Load()
    {
        string key = "MyGame";
        if (PlayerPrefs.HasKey(key))
        {
            string value = PlayerPrefs.GetString(key);

            SaveData data = JsonUtility.FromJson<SaveData>(value);

            this.viewers = data.Viewers;
            this.money = data.Money;
        }
    }
}
public class SaveData
{
    public int Viewers;
    public int Money;
}