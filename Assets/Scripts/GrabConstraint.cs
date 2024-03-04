using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabConstraint : MonoBehaviour
{
    public float minZ = -1f; // Minimum Z-axis value in local space
    public float maxZ = 1f; // Maximum Z-axis value in local space

    private Rigidbody rb;
    private XRGrabInteractable grabInteractable;
    private Vector3 startPos;
    [Header("Sliding Door Parts")]
    [SerializeField] SlidingDoorManager doorManager; //Use only with SlidingDoors
    public bool setDoor = false;
    public Transform positionRef;

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

    private void Update()
    {
        positionRef.position = transform.position;
    }


    void LateUpdate()
    {
        // Check if the object is grabbed
        if (true)
        {
            // Get the current local position of the object
            Vector3 localPosition = positionRef.localPosition;

            // Constrain movement along the Z-axis in local space
            localPosition.z = Mathf.Clamp(localPosition.z, minZ, maxZ);

            localPosition = new Vector3(startPos.x, startPos.y, localPosition.z);

            // Update the local position of the object
            transform.localPosition = localPosition;
            positionRef.localPosition = localPosition;

            if (setDoor)
            {
                float progress = positionRef.localPosition.z - minZ;
                float percentage = progress / (maxZ - minZ);
                // Debug.Log(percentage);
                doorManager.moveDoor(percentage);
            }
        }
    }
}