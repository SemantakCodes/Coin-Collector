using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    
    private void Update()
    {
        player.GetComponent<PlayerMovement>().enabled = true;
        if(player.transform.position.z > 5.15)
        {
            player.GetComponent<PlayerMovement>().enabled = false;
        }
        if(player.transform.position.z > -5.15)
        {
            player.GetComponent<PlayerMovement>().enabled = false;
        }

    }
}
