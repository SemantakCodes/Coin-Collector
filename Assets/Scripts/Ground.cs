using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float GroundSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.right * GroundSpeed * Time.deltaTime);
    }
}
