

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTouchController : MonoBehaviour
{
    public float moveSpeed = 8f;

    private Camera mainCamera;
    private Vector3 targetPosition;

    void Start()
    {
        mainCamera = Camera.main;
        targetPosition = transform.position;
    }

    void Update()
    {
        Vector2 pointerPosition = Vector2.zero;
        bool pointerPressed = false;

        if (Touchscreen.current != null &&
            Touchscreen.current.primaryTouch.press.isPressed)
        {
            pointerPosition =
                Touchscreen.current.primaryTouch.position.ReadValue();

            pointerPressed = true;
        }
        else if (Mouse.current != null &&
                 Mouse.current.leftButton.isPressed)
        {
            pointerPosition = Mouse.current.position.ReadValue();
            pointerPressed = true;
        }

        if (pointerPressed && mainCamera != null)
        {
            Vector3 worldPosition =
                mainCamera.ScreenToWorldPoint(pointerPosition);

            targetPosition = new Vector3(
                worldPosition.x,
                worldPosition.y,
                transform.position.z
            );
        }

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            moveSpeed * Time.deltaTime
        );
    }
}
