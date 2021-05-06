using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CantThinkOfAName
{
    public class Input_base : MonoBehaviour
    {
        #region Variables
        [Header("Base input properties")]
        protected float VerticalInput = 0f;
        protected float HorizontalInput = 0f;
        #endregion

        #region Base Methods
        void Update()
        {
            HandleInputs();
        }
        #endregion

        #region Custom Methods
        protected virtual void HandleInputs() // protected: available in this "parent classes" and it's "child classes"
        {
            VerticalInput = Input.GetAxis("Vertical");
            HorizontalInput = Input.GetAxis("Horizontal");
        }
        #endregion
    }
}
