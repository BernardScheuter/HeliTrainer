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
public class Input_Controller : MonoBehaviour
{
    #region Variables
    public InputType inputType = InputType.Keyboard;

    [Header("Input Components")]
    public Input_Keyboard keyInput;
    public Input_XboxController xboxInput;
    #endregion

    #region Builtin Methods
    // Start is called before the first frame update
    void Start()
    {
        SetInputType(inputType);
    }
    #endregion

    #region Custom Methods
    void SetInputType(InputType type)
    {
        if (keyInput && xboxInput)
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
    }
    #endregion

}
