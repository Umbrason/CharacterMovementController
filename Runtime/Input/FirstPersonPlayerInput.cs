using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonPlayerInput : MonoBehaviour, GameplayInputs.IFPSControlsActions
{
    private GameplayInputs Inputs;
    private Cached<Jump> CachedJumpController = new(Cached<Jump>.GetOption.Children);
    private Jump Jump => CachedJumpController[this];
    private Cached<WalkingController> CachedWalkingController = new(Cached<WalkingController>.GetOption.Children);
    private WalkingController Walk => CachedWalkingController[this];
    private Cached<CameraRotation> CachedCameraRotation = new(Cached<CameraRotation>.GetOption.Children);
    private CameraRotation CameraRotation => CachedCameraRotation[this];
    private Cached<CrouchController> CachedCrouch = new(Cached<CrouchController>.GetOption.Children);
    private CrouchController Crouch => CachedCrouch[this];

    public void OnJump(InputAction.CallbackContext context) => Jump.SetInput(context);
    public void OnMove(InputAction.CallbackContext context) => Walk.SetInput(context);
    public void OnLook(InputAction.CallbackContext context) => CameraRotation.HandleInput(context);
    public void OnCrouch(InputAction.CallbackContext context) => Crouch.SetInput(context);

    private void Start()
    {
        Inputs = new();
        Inputs.Enable();
        Inputs.FPSControls.SetCallbacks(this);
    }
}
