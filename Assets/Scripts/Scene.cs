using UnityEngine;
using UnityEngine.SceneManagement; // لاستخدام SceneManager
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
    public AudioSource StartSound;
    public Button startButton;
    public string gameSceneName = "Game"; // اسم المشهد الذي تريد الانتقال إليه

    // هذه الدالة ستُستدعى عند الضغط على زر البداية
    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName); // تحميل المشهد
    }
}
