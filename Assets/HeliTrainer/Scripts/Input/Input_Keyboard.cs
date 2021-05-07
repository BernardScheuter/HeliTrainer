using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CantThinkOfAName;

public class Input_Keyboard : Input_base
{
    #region Variables
    protected float throttleInput = 0f;
    protected float stickyThrottle = 0f;
    protected float colletiveInput = 0f;
    protected Vector2 cyclicInput = Vector2.zero; // = shorthand for Vector2(0,0)
    protected float pedalInput = 0f;
    #endregion

    #region Properties
    public float RawThrottleInput
    { get { return throttleInput; } }
    public float StickyThrottle
    { get { return stickyThrottle; } }
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

        // Input Methods
        HandleThrottle();
        HandleCollective();
        HandleCyclic();
        HandlePedal();

        // Utility Methods
        ClampInputs();
        HandleStickyThrottle();
    }

    /// <summary>
    /// Handles the RPM of the engine
    /// </summary>
    protected virtual void HandleThrottle()
    {
        throttleInput = Input.GetAxis("Throttle");
    }

    /// <summary>
    /// Handles the lift up of the chopper
    /// </summary>
    protected virtual void HandleCollective()
    {
        colletiveInput = Input.GetAxis("Collective");
    }

    /// <summary>
    /// Handles rotation of the main Rotor
    /// Is a Vector2
    /// </summary>
    protected virtual void HandleCyclic()
    {
        cyclicInput.x = HorizontalInput;
        cyclicInput.y = VerticalInput;
    }

    /// <summary>
    /// 
    /// </summary>
    protected virtual void HandlePedal()
    {
        pedalInput = Input.GetAxis("Pedal");
    }

    protected void ClampInputs()
    {
        throttleInput = Mathf.Clamp(throttleInput, -1f, 1f);
        colletiveInput = Mathf.Clamp(colletiveInput, -1f, 1f);
        cyclicInput = Vector2.ClampMagnitude(cyclicInput, 1); // oplossing tut
        //cyclicInput.x = Mathf.Clamp(cyclicInput.x, -1f, 1f);// oplossing van mij
        //cyclicInput.y = Mathf.Clamp(cyclicInput.y, -1f, 1f);
        pedalInput = Mathf.Clamp(pedalInput, -1f, 1f);
    }

    protected void HandleStickyThrottle() 
    {
        stickyThrottle += RawThrottleInput * Time.deltaTime;
        stickyThrottle = Mathf.Clamp01(stickyThrottle);
        Debug.Log(stickyThrottle);
    }
    #endregion
}