using UnityEngine;
using UnityEngine.UI; // لإدارة الأزرار في الـ UI

public class StoryManager : MonoBehaviour
{
    public Image backgroundImage; // الصورة الخلفية
    public Image storyImage;      // الصورة التي تحتوي على النص

    void Start()
    {
        // إظهار الخلفية والصورة التي تحتوي على النص عند بداية اللعبة
        backgroundImage.gameObject.SetActive(true);
        storyImage.gameObject.SetActive(true);
    }

    void Update()
    {
        // إذا ضغط اللاعب على زر X
        if (Input.GetKeyDown(KeyCode.X))
        {
            // إغلاق الخلفية والنص
            backgroundImage.gameObject.SetActive(false);
            storyImage.gameObject.SetActive(false);
        }
    }
    public void CloseStory()
{
    backgroundImage.gameObject.SetActive(false);
    storyImage.gameObject.SetActive(false);
}

}
