using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // تأكد أن اللاعب لديه الوسم "Player"
        {
            collision.GetComponent<Health>().TekeDamage(9999); // تعطيل الحركة
            gameManager.GameOver();
        }
    }
}
