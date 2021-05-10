using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CantThinkOfAName;

public enum InputType
{
    Keyboard,
    XboxController,
    Mobile
}
[RequireComponent(typeof(Input_Keyboard), typeof(Input_XboxController))]
public class Input_Controller : MonoBehaviour
{
    #region Variables
    public InputType inputType = InputType.Keyboard;

    [Header("Input Properties")]
    private Input_Keyboard keyInput;
    private Input_XboxController xboxInput;

    private float throttleInput;
    public float ThrottleInput
    { get { return throttleInput; } }
    
    private float stickyThrottle;
    public float StickyThrottle
    { get { return stickyThrottle; } }

    private Vector2 cyclicInput;
    public Vector2 CyclicInput
    { get { return cyclicInput; } }

    private float collectiveInput;
    public float CollectiveInput
    { get { return collectiveInput; } }

    private float stickyCollective;
    public float StickyCollective
    { get { return stickyCollective; } }

    private float pedalInput;
    public float PedalInput
    { get { return pedalInput; } }
    #endregion

    #region Builtin Methods
    // Start is called before the first frame update
    void Start()
    {
        keyInput = GetComponent<Input_Keyboard>();
        xboxInput = GetComponent<Input_XboxController>();

        if (keyInput && xboxInput)
        {
            SetInputType(inputType);
        }
    }

    private void Update()
    {
        if (keyInput && xboxInput)
        {
            switch (inputType)
            {
                case InputType.Keyboard:
                    throttleInput = keyInput.RawThrottleInput;
                    collectiveInput = keyInput.CollectiveInput;
                    cyclicInput = keyInput.CyclicInput;
                    pedalInput = keyInput.PedalInput;
                    stickyThrottle = keyInput.StickyThrottle;
                    stickyCollective = keyInput.StickyCollective;
                    break;

                case InputType.XboxController:
                    throttleInput = xboxInput.RawThrottleInput;
                    collectiveInput = xboxInput.CollectiveInput;
                    cyclicInput = xboxInput.CyclicInput;
                    pedalInput = xboxInput.PedalInput;
                    stickyThrottle = xboxInput.StickyThrottle;
                    stickyCollective = xboxInput.StickyCollective;
                    break;

                default:
                    break;
            }
        }
    }
    #endregion

    #region Custom Methods
    void SetInputType(InputType type)
    {
        if (type == InputType.Keyboard)
        {
            keyInput.enabled = true;
            xboxInput.enabled = false;
        }
        if (type == InputType.XboxController)
        {
            keyInput.enabled = false;
            xboxInput.enabled = true;
        }
    }
    #endregion

}
