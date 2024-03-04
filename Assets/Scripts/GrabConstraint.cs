using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabConstraint : MonoBehaviour
{
    public float minZ = -1f; // Minimum Z-axis value in local space
    public float maxZ = 1f; // Maximum Z-axis value in local space

    private Rigidbody rb;
    private XRGrabInteractable grabInteractable;
    private Vector3 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Subscribe to the onSelectEnter and onSelectExit events
        /*        grabInteractable.onSelectEntered.AddListener(OnGrabbed);
                grabInteractable.onSelectExited.AddListener(OnReleased);*/
        startPos = transform.localPosition;
        enabled = true;
    }

    void LateUpdate()
    {
        // Check if the object is grabbed
        if (true)
        {
            // Get the current local position of the object
            Vector3 localPosition = transform.localPosition;

            // Constrain movement along the Z-axis in local space
            localPosition.z = Mathf.Clamp(localPosition.z, minZ, maxZ);

            localPosition = new Vector3(startPos.x, startPos.y, localPosition.z);

            // Freeze movement along other axes
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            // Update the local position of the object
            transform.localPosition = localPosition;
        }
    }

    // Called when the object is grabbed
/*    private void OnGrabbed(XRBaseInteractor interactor)
    {
        // Enable the constraint when the object is grabbed
        enabled = true;
    }

    // Called when the object is released
    private void OnReleased(XRBaseInteractor interactor)
    {
        // Disable the constraint when the object is released
        enabled = false;
    }*/
}