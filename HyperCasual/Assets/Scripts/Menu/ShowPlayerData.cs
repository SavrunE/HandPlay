using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerData : MonoBehaviour
{
    [SerializeField] PlayerData playerData;
    int viewers = 0;

    Text text;
    private void Start()
    {
        text = transform.GetComponent<Text>();
    }
    private void OnEnable()
    {
        playerData.ChangeData += ShowViewers;
    }  
    private void OnDisable()
    {
        playerData.ChangeData -= ShowViewers;
    }
    public void ShowViewers(int viewers)
    {
        this.viewers = viewers;
        text.text = viewers.ToString();
    }
}
