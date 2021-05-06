using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CantThinkOfAName;

public class RBController : MonoBehaviour
{
    #region Variables
    protected Rigidbody RB;
    #endregion

    #region BuiltIn Methods

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandlePhysics();
    }
    #endregion

    #region Custom Methods
    protected virtual void HandlePhysics() 
    { 
    
    }
    #endregion
}
