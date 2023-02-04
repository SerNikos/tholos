using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 1.0f;

    private Vector3 startPosition;
    private bool isMovingUp = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (isMovingUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition + Vector3.up * 10, speed * Time.deltaTime);

            if (transform.position.y >= startPosition.y + 10)
            {
                isMovingUp = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, speed * Time.deltaTime);

            if (transform.position.y <= startPosition.y)
            {
                isMovingUp = true;
            }
        }
    }
}