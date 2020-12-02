using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Loader
{
    public class SceneLoader : MonoBehaviour
    {
        public void ExitToMenu()
        {
            int points = transform.Find("Points").GetComponent<Points>().CurrentValue;
            PlayerData.Instance.ChangeViewers(points);
            SceneManager.LoadScene("Menu");
        }
        public static void LoadScene(string name)
        {
            SceneManager.LoadScene("Scene" + name);
        }

        public static void ToPointMenu()
        {
            Debug.Log("Loader.ScineLoader.ToPointMenu()");
        }
    }
}