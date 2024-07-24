using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Camera fpsCamera;
    public float range = 100f;
    public GameObject bulletPrefab; // ������ ����
    public Transform bulletSpawn;   // ����� ������ ����
    public float bulletSpeed = 20f; // �������� ����

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    /*/
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            // �������� ����
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = fpsCamera.transform.forward * 20f; // ������ �������� ����
            }
        }
    }
    /*/
    void Shoot()
    {
        // �������� ����
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = fpsCamera.transform.forward * bulletSpeed; // ������ �������� ����
        }
    }
}