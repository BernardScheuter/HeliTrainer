using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CantThinkOfAName
{
    public class Heli_Characteristics : MonoBehaviour
    {
        #region Variables
        [Header("Lift Properties")]
        public float maxLiftForce = 100f;
        public HeliMainRotor mainRotor;
        [Space]

        [Header("Tail Rotor properties")]
        public float tailForce = 2f;
        [Space]

        [Header("Cyclic properties")]
        public float cyclicForce = 2f;

        private Vector3 flatForward;
        private Vector3 flatRight;
        #endregion

        #region Buildin Methodes
        #endregion

        #region Custom Methods
        public void UpdateCharacteristics(Rigidbody RB, Input_Controller input)
        {
            HandleLift(RB, input);
            HandleCyclic(RB, input);
            HandlePedals(RB, input);

            CalculateAngles();
            AutoLevel();
        }

        protected virtual void HandleLift(Rigidbody RB, Input_Controller input)
        {
            if (mainRotor)
            {
                Vector3 liftForce = transform.up * (Physics.gravity.magnitude + maxLiftForce * RB.mass);
                float normalizedRPMs = mainRotor.CurrentRPMs / 50f; // 50f is hardcoded for now....
                RB.AddForce(liftForce * Mathf.Pow(normalizedRPMs, 2f) * Mathf.Pow(input.StickyCollective, 2f), ForceMode.Force);
            }
        }

        protected virtual void HandleCyclic(Rigidbody RB, Input_Controller input)
        {
            //Debug.Log("Handling cyclic");
            float cyclicZforce = input.CyclicInput.x * cyclicForce;
            RB.AddRelativeTorque(Vector3.forward * cyclicZforce, ForceMode.Acceleration);
            float cyclicXforce = -input.CyclicInput.y * cyclicForce;
            RB.AddRelativeTorque(Vector3.right * cyclicXforce, ForceMode.Acceleration);
        }

        protected virtual void HandlePedals(Rigidbody RB, Input_Controller input)
        {
            RB.AddTorque(Vector3.up * input.PedalInput * tailForce, ForceMode.Acceleration);
        }

        protected void CalculateAngles() 
        {
            // Calc flat forward
            flatForward = transform.forward;
            flatForward.y = 0f;
            flatForward = flatForward.normalized;
            Debug.DrawRay(transform.position, flatForward, Color.blue);
            // Calc flat right
            flatRight = transform.right;
            flatRight.y = 0f;
            flatRight = flatRight.normalized;
            Debug.DrawRay(transform.position, flatRight, Color.green);

            // Calc Angles

        }

        protected void AutoLevel() 
        { 
        
        }
        #endregion
    }

}