using UnityEngine;
using UnityEngine.UI;
using Loader;

public class Timer : MonoBehaviour
{
    [Range(0.1f, 0.5f)]
    public float ProportionToMedium;
    public Color Started, Medium, Low;
    public bool TimerOn = false;

    float timeToLevel;
    float timeToMedium;
    float timeToLow = 10f;
    int caseSwith = 1;
    Text timer;
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = transform.parent.gameObject.GetComponent<SceneLoader>();
        timeToLevel = transform.parent.GetComponent<LevelSetings>().TimeToLevel;
        timeToMedium = timeToLevel * ProportionToMedium;
        timer = transform.Find("Timer").GetComponent<Text>();
        timer.text = timeToLevel.ToString();
    }
    void Update()
    {
        if (TimerOn)
        {
            timeToLevel -= Time.deltaTime;
            switch (caseSwith)
            {
                case 1:
                    if (timeToMedium > timeToLevel)
                    {
                        caseSwith++;
                        ColorChange(Medium);
                    }
                    break;
                case 2:
                    if (timeToLow > timeToLevel)
                    {
                        caseSwith++;
                        ColorChange(Low);
                    }
                    break;
                case 3:
                    if (timeToLevel <= 0)
                    {
                        TimerOn = false;
                        sceneLoader.ExitToMenu();
                    }
                    break;
            }
            timer.text = timeToLevel.ToString();
        }
    }
    void ColorChange(Color color)
    {
        timer.color = color;
    }
}
