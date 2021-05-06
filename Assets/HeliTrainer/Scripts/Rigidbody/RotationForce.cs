using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CantThinkOfAName;


public class RotationForce : RBController
{
    #region Variables
    public float ForceApplied = 1f;
    #endregion

    #region Methodes
    void Start()
    {
    }
    void FixedUpdate()
    {
        RB.AddTorque(Vector3.up * ForceApplied);
    }
    #endregion
}
