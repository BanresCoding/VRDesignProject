using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SlidingDoorManager : MonoBehaviour
{
    public SkinnedMeshRenderer SlidingDoor;
    public Transform openPos;
    public Transform closePos;

    private void OnEnable()
    {
    }

    private void OnDisable()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(movedoor());
    }



    public void moveDoor(float percentage) 
    {
        SlidingDoor.SetBlendShapeWeight(0, percentage * 100f);
    }




    // Update is called once per frame
    void Update()
    {

        


    }



}
