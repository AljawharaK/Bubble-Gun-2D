using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate = 0.5f; // المدة الزمنية بين كل إطلاق (ثانية)
    private float nextFireTime = 0f; // الوقت التالي الذي يمكن فيه إطلاق الفقاعة
    public AudioSource StartSound;



    void Update()
    {
        // التحقق من ضغط زر المسافة (أو أي مفتاح تريده لإطلاق الفقاعة)
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate; // تعيين الوقت التالي للإطلاق
            StartSound.Play();
            
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
