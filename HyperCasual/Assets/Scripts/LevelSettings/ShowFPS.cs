using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFPS : MonoBehaviour
{
    public float Fps;
    Text fpsText;
    int fps;
    private void Start()
    {
        fpsText = transform.Find("Timer").GetComponent<Text>();
        fpsText.text = ("FPS: " + (int)Fps);
        StartCoroutine(FPSChecker());
    }
    void Update()
    {
        fps++;
    }
    IEnumerator FPSChecker()
    {
        while (true)
        {
            fps = 0;
            yield return new WaitForSeconds(1f);
            fpsText.text = ("FPS: " + fps);
        }
    }
}