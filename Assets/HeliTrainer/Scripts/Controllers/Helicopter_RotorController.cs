using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace CantThinkOfAName
{

    public class Helicopter_RotorController : MonoBehaviour
    {
        #region Variables
        private List<IHeliRotor> rotors;
        
        #endregion

        #region Buildin Methods
        private void Start()
        {
            rotors = GetComponentsInChildren<IHeliRotor>().ToList<IHeliRotor>();
        }
        #endregion

        #region Custom Methods
        public void UpdateRotors(Input_Controller input, float currentRPMs) 
        {
            //Debug.Log("Degree Per Second calc:\nCurrentRPMS value: " + currentRPMs);
            float dps = ((currentRPMs * 360f) / 60f) * Time.deltaTime;

            if (rotors.Count > 0) 
            {
                foreach (var rotor in rotors) 
                {
                    rotor.UpdateRotor(dps, input);
                }
            }
        }
        #endregion
    }
}