using UnityEngine;
using Loader;

public class MainMenu : MonoBehaviour
{
   public void StartGame()
    {
        SceneLoader.LoadScene("Brown");
    }
    public void PointMenu()
    {
        SceneLoader.ToPointMenu();
    }
}
