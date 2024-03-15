using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Fuel { Basic };

public class RefillStationManager : MonoBehaviour
{
    public Fuel stationFuel;
    [SerializeField]BoxCollider triggerArea;

    public Transform snapAnchor;

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawWireCube(transform.position + triggerArea.center, triggerArea.size);
    }

    // Start is called before the first frame updat 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
