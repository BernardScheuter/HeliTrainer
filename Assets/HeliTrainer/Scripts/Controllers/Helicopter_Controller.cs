using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CantThinkOfAName
{
    [RequireComponent(typeof(Input_Controller))]
    public class Helicopter_Controller : RBController
    {
        #region Variables
        //[Header("Controller Properties")]
        private Input_Controller input;
        #endregion

        #region Custom Methods
        protected override void HandlePhysics()
        {
            input = GetComponent<Input_Controller>();
            if (input)
            {
                HandleEngines();
                HandleCharacteristics();
            }
        }
        #endregion
        
        #region Helicopter Control Methods
        protected virtual void HandleEngines() { }

        protected virtual void HandleCharacteristics() { }
        #endregion
    }

}