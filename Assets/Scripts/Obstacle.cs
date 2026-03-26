using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float ObstacleSpeed = 25;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * ObstacleSpeed * Time.deltaTime);
        if(transform.position.x > 50f)
        {
            Destroy(gameObject);
        }
    }
}
