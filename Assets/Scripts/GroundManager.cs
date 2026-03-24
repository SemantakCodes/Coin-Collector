using System;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject EndPoint;
    [SerializeField] private GameObject Obstacles;
    [SerializeField] private Transform Player;
    [SerializeField] private GameObject Ground;

    private void SpawnGround(GameObject groundObject, GameObject OriginPoint)
    {
        Instantiate(Ground, OriginPoint.transform.position, Quaternion.identity);
    }
    private void Start()
    {
        SpawnGround(Ground, spawnPoint);
    }
}
