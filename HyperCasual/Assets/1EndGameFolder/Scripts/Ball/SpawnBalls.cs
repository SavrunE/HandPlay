using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    public GameObject gameObject;

    Vector3 position;
    float spawnDelay;
    int spawnBallsCount;
    void Start()
    {
        position = transform.position;
        spawnDelay = transform.parent.GetComponent<LevelSetings>().SpawnDelay;
        spawnBallsCount = transform.parent.GetComponent<LevelSetings>().SpawnBallsCount;
        StartCoroutine(BallsSpawner());
    }
    IEnumerator BallsSpawner()
    {
        int correntCount = 0;
        while (spawnBallsCount > correntCount++)
        {
            Instantiate(gameObject, new Vector3(Random.Range(position.x -1f, position.x + 1f),position.y,position.z), Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
