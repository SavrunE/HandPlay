using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionMouth : MonoBehaviour
{
    public float ShowTimeEmote = 2f;

    [SerializeField] List<Sprite> emotionMouths;
    Sprite defaultMouth;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultMouth = spriteRenderer.sprite;
    }

    public void ChangeMouth()
    {
        StartCoroutine(MouthChanger());
    }

    IEnumerator MouthChanger()
    {
        int randomEmote = Random.Range(0, emotionMouths.Count);
        spriteRenderer.sprite = emotionMouths[randomEmote];

        yield return new WaitForSeconds(ShowTimeEmote);
        spriteRenderer.sprite = defaultMouth;
    }
}
