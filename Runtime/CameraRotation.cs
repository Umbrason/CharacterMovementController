
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{    
    public float sensitivity = 1f;

    private float rx;
    private float ry;

    public void HandleInput(InputAction.CallbackContext callbackContext)
    {
        var delta = callbackContext.ReadValue<Vector2>() * sensitivity * .05f;
        rx -= delta.y;
        ry += delta.x;
        rx = Mathf.Clamp(rx, -90, 90);
        ry = (ry + 360f) % 360;
        transform.localRotation = Quaternion.Euler(rx, ry, transform.localEulerAngles.z);
    }
}
