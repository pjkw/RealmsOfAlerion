using UnityEngine;

public class EaseIn : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 endPos;
    public float duration;
    private float startTime;
    private float journeyLength;

    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPos, endPos);
    }

    void Update()
    {
        float distCovered = (Time.time - startTime) * duration;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startPos, endPos, fracJourney);
    }
}
