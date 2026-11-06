using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        // قراءة المدخلات الخاصة بالحركة
        horizontal = Input.GetAxisRaw("Horizontal");  // الحركة يمين ويسار (أسهم أو A/D)
        vertical = Input.GetAxisRaw("Vertical");      // للحركة لأعلى ولأسفل (الأسهم أو W/S)

        // القفز عند ضغط السهم الأعلى أو حرف W
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);
        }

        // تقليل سرعة القفز عندما يتم رفع السهم الأعلى أو حرف W
        if ((Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W)) && rb.linearVelocity.y > 0f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }

        // التعامل مع تغيير الاتجاه
        Flip();
    }

    private void FixedUpdate()
    {
        // تحديث الحركة الأفقية باستخدام الأسهم أو A/D
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
