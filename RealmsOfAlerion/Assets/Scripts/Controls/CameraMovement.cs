using System.Collections;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float easing = 0.1f;

    private Vector3 targetPos;

    void Start()
    {
        targetPos = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            targetPos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            targetPos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            targetPos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            targetPos.x += speed * Time.deltaTime;
        }

        transform.position = Vector3.Lerp(transform.position, targetPos, easing);
    }
}
