using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;

    public void GameOver(){
        GameOverUI.SetActive(true);
    }
}
