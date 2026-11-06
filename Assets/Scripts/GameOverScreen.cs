using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public void Setup(int score){
        gameObject.SetActive(true);
    }

    public void RestartButton(){
        SceneManager.LoadScene("Game");
    }
}
