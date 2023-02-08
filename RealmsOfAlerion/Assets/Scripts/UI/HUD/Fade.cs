using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    [SerializeField] float fadeDuration = 1f;
    [SerializeField] float initialDelay = 3f;
    [SerializeField] Canvas canvas;
    CanvasGroup canvasGroup;

    void Awake()
    {
        canvasGroup = canvas.GetComponent<CanvasGroup>();
    }

    void Start()
    {
        StartCoroutine(FadeOut(initialDelay));
    }

    IEnumerator FadeOut(float _initialDelay)
    {
        yield return new WaitForSeconds(_initialDelay);
        canvasGroup.alpha = 1f;
        while (canvasGroup.alpha > 0f)
        {
            canvasGroup.alpha -= Time.deltaTime / fadeDuration;
            yield return null;
        }
    }
}