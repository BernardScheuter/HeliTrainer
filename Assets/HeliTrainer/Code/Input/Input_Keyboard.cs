using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CantThinkOfAName
{
    public class Input_Keyboard : Input_base
    {
        #region Variables
        private float throttleInput = 0f;
        private float colletiveInput = 0f;
        private float cyclicInput = 0f;
        private float pedalInput = 0f;
        #endregion
        
        #region Properties
        public float ThrottleInput
        { get {return throttleInput;} }
        public float CollectiveInput
        { get {return colletiveInput; }}
        public float CyclicInput
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
            throttleInput = VerticalInput;
            pedalInput = HorizontalInput;
        }
        #endregion
    }
}
