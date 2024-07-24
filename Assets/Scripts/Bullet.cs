using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float lifetime = 2f;

    void Start()
    {
        Destroy(gameObject, lifetime); // Уничтожить пулю через определенное время
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Добавьте логику при столкновении с объектом
        Destroy(gameObject); // Уничтожить пулю при столкновении
    }
}