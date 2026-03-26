using Unity.VisualScripting;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private float ranPos;
    [SerializeField] private GameObject Obstacle;
    private Vector3 newSpawnPoint;
    private float timer;
    [SerializeField] private float timerDelay;

    private void Start()
    {
        
    }
    private void Update()
    {
        SpawnObstacle();
    }
    private void SpawnObstacle()
    {
        timer += Time.deltaTime;
        ranPos = Random.Range(3,-7);
        if(timer >= timerDelay)
        {
            newSpawnPoint.x = spawnPoint.transform.position.x;
            newSpawnPoint.y = spawnPoint.transform.position.y;
            newSpawnPoint.z = ranPos;
            Instantiate(Obstacle, newSpawnPoint, Quaternion.identity);
            timer = 0f;
        }
        
    }
}
