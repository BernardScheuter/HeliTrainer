using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CantThinkOfAName;

public class Input_Keyboard : Input_base
{
    #region Variables
    private float throttleInput = 0f;
    private float colletiveInput = 0f;
    private Vector2 cyclicInput = Vector2.zero; // = shorthand for Vector2(0,0)
    private float pedalInput = 0f;
    #endregion

    #region Properties
    public float ThrottleInput
    { get { return throttleInput; } }
    public float CollectiveInput
    { get { return colletiveInput; } }
    public Vector2 CyclicInput
    { get { return cyclicInput; } }
    public float PedalInput
    { get { return pedalInput; } }
    #endregion

    #region Base Methods
    #endregion

    #region Custom Methods
    protected override void HandleInputs()
    {
        base.HandleInputs();
        HandleThrottle();
        HandleCollective();
        HandleCyclic();
        HandlePedal();
    }

    /// <summary>
    /// Handles the RPM of the engine
    /// </summary>
    void HandleThrottle()
    {
        throttleInput = Input.GetAxis("Throttle");
    }

    /// <summary>
    /// Handles the lift up of the chopper
    /// </summary>
    void HandleCollective()
    {
        colletiveInput = Input.GetAxis("Collective");
    }

    /// <summary>
    /// Handles rotation of the main Rotor
    /// Is a Vector2
    /// </summary>
    void HandleCyclic()
    {
        cyclicInput.x = HorizontalInput;
        cyclicInput.y = VerticalInput;
    }

    /// <summary>
    /// 
    /// </summary>
    void HandlePedal()
    {
        pedalInput = Input.GetAxis("Pedal");
    }
    #endregion
}