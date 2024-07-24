using UnityEngine;
/*/
public class CameraFollow : MonoBehaviour
{
    public Transform target; // Игрок
    public Vector3 offset;   // Смещение камеры относительно игрока
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
/*/


public class CameraFollow : MonoBehaviour
{
    public Transform target; // Игрок
    public Vector3 offset;   // Смещение камеры относительно игрока

    void Start()
    {
        transform.position = target.position + offset;
        transform.SetParent(target); // Делаем камеру дочерним объектом игрока
    }
}