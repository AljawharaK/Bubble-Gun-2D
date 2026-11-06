using UnityEngine;
using UnityEngine.UI; // لإضافة التحكم بالأزرار

public class ButtonSound : MonoBehaviour
{
    public AudioSource buttonClickSound; // المصدر الصوتي
    public Button startButton;          // الزر الذي سيشغل الصوت

    void Start()
    {
        // إضافة حدث عند الضغط على الزر
        startButton.onClick.AddListener(PlaySound);
    }

    // دالة تشغيل الصوت عند الضغط على الزر
    void PlaySound()
    {
        buttonClickSound.Play();
    }
}
