using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CantThinkOfAName
{
    public class Heli_Characteristics : MonoBehaviour
    {
        #region Variables
        #endregion

        #region Buildin Methodes
        #endregion

        #region Custom Methods
        public void UpdateCharacteristics()
        {
            HandleLift();
            HandleCyclic();
            HandlePedals();
        }

        protected virtual void HandleLift()
        {
            //Debug.Log("Handling lift");
        }

        protected virtual void HandleCyclic()
        {
            //Debug.Log("Handling cyclic");
        }

        protected virtual void HandlePedals()
        {
            //Debug.Log("Handling pedals");
        }
        #endregion
    }

}