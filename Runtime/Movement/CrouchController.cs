using UnityEngine;
using UnityEngine.InputSystem;

public class CrouchController : MonoBehaviour
{
    [SerializeField] private ConfigurableJoint spine;
    [SerializeField] private Rigidbody headRB;
    [SerializeField] private Collider bodyCollider;
    [SerializeField] private Collider headCollider;
    [SerializeField] private Collider neckCollider;
    public float crouchLen;
    public float standingLen;
    bool crouching = false;
    public bool Crouching => crouching;

    void OnEnable()
    {
        headRB.sleepThreshold = -1f;
        Physics.IgnoreCollision(headCollider, neckCollider);
        Physics.IgnoreCollision(neckCollider, bodyCollider);
        Physics.IgnoreCollision(bodyCollider, headCollider);
    }
    public void SetInput(InputAction.CallbackContext callbackContext) => crouching = callbackContext.ReadValueAsButton();

    void FixedUpdate()
    {
        var spineLen = crouching ? crouchLen : standingLen;
        spine.connectedAnchor = transform.TransformPoint(Vector3.up * spineLen);
        headRB.transform.localPosition = headRB.transform.localPosition._0y0();
        neckCollider.enabled = headCollider.enabled = !(spine.transform.localPosition.y > spineLen + .1f); //no decapitation
    }
}
