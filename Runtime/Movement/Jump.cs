
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CollisionInfo), typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    [SerializeField] private int jumpCount;
    [SerializeField] private float CoyoteTime = .1f;

    [SerializeField] private float JumpHeight;

    private VelocityController cached_VC;
    private VelocityController VC => cached_VC ??= GetComponent<VelocityController>();

    private CollisionInfo cached_CI;
    private CollisionInfo CI => cached_CI ??= GetComponent<CollisionInfo>();

    private bool JumpInput;
    private bool _jumpReleased;
    public void SetInput(InputAction.CallbackContext callback) => JumpInput = callback.ReadValueAsButton();

    private int jumpsPerformed;
    void DoJump()
    {
        if (jumpCount < jumpsPerformed + 1) return;
        if (CoyoteTime < Time.fixedTime - lastGroundTime) jumpsPerformed++;
        var velocity = Mathf.Sqrt(2 * -Physics.gravity.y * JumpHeight);
        VC.AddLayer(priority: 1, velocity: Vector3.up * Mathf.Max(velocity, VC.Velocity.y), blend: VelocityLayer.BlendMode.Blend, channelMask: VelocityLayer.ChannelMask.Y);
        lastGroundTime = float.MinValue;
    }

    void JumpInputChanged(bool jumpInput)
    {
        this.JumpInput = jumpInput;
        if (jumpInput) DoJump();
    }

    private float lastGroundTime;
    void FixedUpdate()
    {
        var jumpWasPressed = JumpInput;
        JumpInput ^= _jumpReleased;
        if (!CI.FlatGround) return;
        lastGroundTime = Time.fixedTime;
        if (jumpWasPressed) DoJump();
        jumpsPerformed = 0;
    }


}
