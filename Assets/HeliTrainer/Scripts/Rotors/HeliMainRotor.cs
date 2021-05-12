using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CantThinkOfAName
{
    public class HeliMainRotor : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Main Rotor Properties")]
        public Transform LRotor;
        public Transform RRotor;
        public float maxPitch = 25f;
        #endregion

        #region Properties
        private float currentRPMs;
        public float CurrentRPMs 
        {
            get { return currentRPMs; }
        }
        #endregion

        #region Default Methods
        void Start()
        {

        }
        #endregion

        #region Interface Methods
        public void UpdateRotor(float dps, Input_Controller input)
        {
            //Debug.Log("Updating Main Rotor\ndps value: " + dps);
            currentRPMs = (dps / 360) * 60f;
            transform.Rotate(Vector3.up, dps);
            // Pitch blade up/down
            if (LRotor && RRotor)
            {
                LRotor.localRotation = Quaternion.Euler(-input.StickyCollective * maxPitch, 0f, 0f) ;
                RRotor.localRotation = Quaternion.Euler(input.StickyCollective * maxPitch, 0f, 0f) ;
            }
        }
        #endregion
    }
}