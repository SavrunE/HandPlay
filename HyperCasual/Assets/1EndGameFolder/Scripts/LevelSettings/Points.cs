using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int CurrentValue = 0;

    int pointsToWin;
    Text Point;
    Text ToWinPoints;

    void Start()
    {
        pointsToWin = transform.parent.GetComponent<LevelSetings>().PointsToWin;
        Point = transform.Find("Current").GetComponent<Text>();
        ToWinPoints = transform.Find("ToWin").GetComponent<Text>();
        ToWinPoints.text = pointsToWin.ToString();
        ChangePoints(CurrentValue);
    }

    public void ChangePoints(int value)
    {
        CurrentValue += value;
        Point.text = CurrentValue.ToString();
        if (CurrentValue >= pointsToWin)
        {
            //u win
        }
    }
}
