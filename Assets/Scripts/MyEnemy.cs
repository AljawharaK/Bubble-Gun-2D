using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    public int health = 20;  // صحة العدو
    public Animator animator;  // للأنيميشن
    public float patrolSpeed = 2f;  // سرعة الحركة
    public float patrolDistance = 5f;  // المسافة التي يتحرك فيها العدو
    private Vector3 startPosition;  // نقطة البداية
    private bool movingRight = true;  // للتحكم في الاتجاه

    private void Start()
    {
        startPosition = transform.position;  // حفظ مكان العدو عند البداية
    }

    private void Update()
    {
        Patrol();

        // إذا كانت الصحة أقل من أو تساوي 0، قم بتشغيل الأنيميشن وتدمير العدو
        if (health <= 0)
        {
            Die();
        }
    }

    private void Patrol()
    {
        // يتحرك العدو فقط ضمن المسافة المحددة له
        if (movingRight)
        {
            transform.Translate(Vector2.right * patrolSpeed * Time.deltaTime);
            
            // إذا تجاوز العدو المسافة المحددة، غير الاتجاه
            if (Vector3.Distance(transform.position, startPosition) >= patrolDistance)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector2.left * patrolSpeed * Time.deltaTime);
            
            // إذا عاد العدو إلى نقطة البداية، غير الاتجاه
            if (Vector3.Distance(transform.position, startPosition) <= 0.1f)
            {
                movingRight = true;
            }
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;  // تقليل الصحة عند تلقي الضرر

        // إذا كانت الصحة أقل من أو تساوي 0، قم بتشغيل الأنيميشن
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        animator.SetTrigger("Die");  // تشغيل أنيميشن الموت باستخدام Trigger

        // بعد فترة قصيرة من موت العدو، قم بتدمير العدو
        Destroy(gameObject, 0.5f);  // افتراضًا الأنيميشن يحتاج 1 ثانية لإكماله
    }
}
