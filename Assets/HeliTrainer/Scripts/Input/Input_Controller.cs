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
