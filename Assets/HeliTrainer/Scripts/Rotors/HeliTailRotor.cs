using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CantThinkOfAName
{
    public class HeliTailRotor : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Tail Rotor properties")]
        public float tailRotormodifier = 1.5f;
        public Transform LtailRotor;
        public Transform RtailRotor;
        public float maxTailPitch = 35f;
        #endregion

        #region Default Methods
        void Start()
        {

        }
        #endregion

        #region Interface Methods
        public void UpdateRotor(float dps, Input_Controller input)
        {
            transform.Rotate(Vector3.right, dps * tailRotormodifier);
            if (LtailRotor && RtailRotor)
            {
                LtailRotor.localRotation = Quaternion.Euler(0f, input.PedalInput * maxTailPitch, 0f);
                RtailRotor.localRotation = Quaternion.Euler(0f, -input.PedalInput * maxTailPitch, 0f);
            }
        }
        #endregion
    }
}