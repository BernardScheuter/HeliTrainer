using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CantThinkOfAName;

public class Input_XboxController : Input_Keyboard
{
    #region Custom Methods
    protected override void HandleThrottle() 
    {
        throttleInput = Input.GetAxis("ControllerThrottleUp") + -Input.GetAxis("ControllerThrottleDown"); ;
    }
    protected override void HandleCollective()
    {
        colletiveInput = Input.GetAxis("ControllerCollective");
    }
    protected override void HandleCyclic()
    {
        cyclicInput.x = Input.GetAxis("ControllerHorizontal");
        cyclicInput.y = Input.GetAxis("ControllerVertical");
    }
    protected override void HandlePedal()
    {
        pedalInput = Input.GetAxis("ControllerPedal");
    }
    #endregion
}
