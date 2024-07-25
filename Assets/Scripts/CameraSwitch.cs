using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera thirdPersonCamera;
    public Camera firstPersonCamera;
    public GameObject player; // объект игрока для управления движением
    public GameObject crosshair;
    [HideInInspector] public bool isThirdPerson = true;

    void Start()
    {
        thirdPersonCamera.enabled = true;
        firstPersonCamera.enabled = false;
        crosshair.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        isThirdPerson = !isThirdPerson;
        thirdPersonCamera.enabled = isThirdPerson;
        firstPersonCamera.enabled = !isThirdPerson;

        // Переключение управления игроком
        if (isThirdPerson)
        {
            player.GetComponent<PlayerMovement>().enabled = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            crosshair.SetActive(false); // Отключаем прицел
        }
        else
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            crosshair.SetActive(true); // Включаем прицел
        }
    }
}