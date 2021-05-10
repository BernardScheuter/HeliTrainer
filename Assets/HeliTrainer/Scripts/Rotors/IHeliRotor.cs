using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CantThinkOfAName
{

    public interface IHeliRotor
    {
        #region Methods
        void UpdateRotor(float dps, Input_Controller input);
        #endregion
    }
}