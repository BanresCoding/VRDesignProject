using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerManager : MonoBehaviour
{
    public XRController rightHand;
    public InputHelpers.Button button;

    void Update()
    {

        bool pressed;
        rightHand.inputDevice.IsPressed(button, out pressed);

        if (pressed)
        {
            Debug.Log("Hello - " + button);
        }
    }
}