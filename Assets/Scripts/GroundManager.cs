using System;
using Unity.VisualScripting;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject EndPoint;
    [SerializeField] private GameObject Obstacles;
    [SerializeField] private Transform Player;
    [SerializeField] private GameObject Ground;
    [SerializeField] private float groundOnScreen;
    private float timer;
    [SerializeField] private float timeDelay;
    private float groundLength;
    private void SpawnGround(GameObject groundObject, GameObject OriginPoint)
    {
        if(timer > timeDelay)
        {
            Instantiate(groundObject, OriginPoint.transform.position, Quaternion.identity);
            timer = 0f;
        }
    }
    private void Update()
    {
        timer += Time.deltaTime;
        SpawnGround(Ground, spawnPoint);

    }
    private void Start()
    {
        
    }

    
}
