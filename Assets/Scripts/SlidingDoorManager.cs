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



    public IEnumerator movedoor()
    {
        SlidingDoor.SetBlendShapeWeight(0, SlidingDoor.GetBlendShapeWeight(0) + 2.5f);
        if (SlidingDoor.GetBlendShapeWeight(0) >= 100)
        {
            SlidingDoor.SetBlendShapeWeight(0, 0);
        }
        yield return new WaitForSeconds(0.05f);
        StartCoroutine(movedoor());
    }

    // Update is called once per frame
    void Update()
    {

        


    }



}
