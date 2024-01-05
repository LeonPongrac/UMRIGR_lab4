using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public float moveDistance = 100.0f;

    private int direction = 1; 

    void Update()
    {
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);

        if (Mathf.Abs(transform.position.x) > moveDistance)
        {
            direction *= -1;
        }
    }
}
