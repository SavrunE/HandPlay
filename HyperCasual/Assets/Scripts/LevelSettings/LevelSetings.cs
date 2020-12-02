using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSetings : MonoBehaviour
{
    [Header("Balls")]
    public float SpawnDelay = 3f;
    public int SpawnBallsCount = 20;

    [Header("End level settings")]
    public int PointsToWin = 18;
    public float TimeToLevel = 60f;
}
