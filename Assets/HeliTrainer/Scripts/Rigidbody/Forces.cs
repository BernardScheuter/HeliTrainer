using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CantThinkOfAName;

public class Forces : RBController
{
    #region Variables
    public float maxSpeed = 1f;
    public Vector3 movementDirection = new Vector3(0f, 0f, 1f);
    #endregion

    #region Methodes
    protected override void HandlePhysics()
    {
        RB.AddForce(movementDirection * maxSpeed);
    }
    #endregion
}
