using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float ObstacleSpeed = 15f;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.right * ObstacleSpeed * Time.deltaTime, ForceMode.VelocityChange);
        if(transform.position.x > 50f)
        {
            Destroy(gameObject);
        }
    }
}
