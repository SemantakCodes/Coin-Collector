using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float GroundSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * GroundSpeed * Time.deltaTime);

        if(transform.position.x > 30f)
        {
            Destroy(gameObject);
        }
    }
}
