using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private string restartMenu;
    
    private void Update()
    {
        

        if(player.IsDestroyed() == true)
        {
            SceneManager.LoadScene(restartMenu);
        }
    }
}
