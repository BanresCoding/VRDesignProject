using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SlidingDoorManager : MonoBehaviour
{
    public SkinnedMeshRenderer SlidingDoor;
    public Transform openPos;
    public Transform closePos;

    [SerializeField] BoxCollider col;
    [SerializeField] Vector3 colliderSizeMax;
    [SerializeField] Vector3 colliderSizeMin;
    [SerializeField] Vector3 colliderCenterMax;
    [SerializeField] Vector3 colliderCenterMin;
    private void OnEnable()
    {
    }

    private void OnDisable()
    {

    }

    private void LateUpdate()
    {
        
    }


    public void moveDoor(float percentage) 
    {
        SlidingDoor.SetBlendShapeWeight(0, percentage * 100f);
        col.size = Vector3.Lerp(colliderSizeMax, colliderSizeMin, percentage);
        col.center = Vector3.Lerp(colliderCenterMax, colliderCenterMin, percentage);

        if (col == null)
        {
            Debug.LogWarning("Collider reference is null.");
            return;
        }

    }
    private void OnDrawGizmos()
    {
        DrawColliderBoundsGizmo();
    }

    // Call this function to visualize the bounding box of the collider when the object is selected
    private void OnDrawGizmosSelected()
    {
        DrawColliderBoundsGizmo();
    }

    private void DrawColliderBoundsGizmo()
    {
        if (col == null)
        {
            Debug.LogWarning("Collider reference is null.");
            return;
        }

        Bounds bounds = col.bounds;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
    // Update is called once per frame
    void Update()
    {

    }



}
