using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CantThinkOfAName;

public class Hover : RBController
{
    #region Variables
    [Header("Hover properties")]
    public float hoverHeight = 3f;
    public Transform hoverPosition;
    public float dragFactor = 0.05f;
    public float torqueSpeed = 4f;

    [Header("Physics")]
    //private Rigidbody RB;
    private float weight;
    private float currentGroundDistance;
    #endregion

    #region Methods
    void Start()
    {
      //  RB = GetComponent<Rigidbody>();
      //  if (RB)
      //  {
            weight = RB.mass * Physics.gravity.magnitude;
      //  }
    }

    void FixedUpdate()
    {
        CalculateGroundDistance();
        HandleHoverForce();
        HandleTorque();
        HandleDrag();
    }
    #endregion

    #region Custom Methods
    void CalculateGroundDistance() 
    {
        Ray hoverRay = new Ray(hoverPosition.position, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(hoverRay, out hit, 100f)) 
        {
            if (hit.transform.tag == "ground") 
            {
                currentGroundDistance = hit.distance;
            }
        
        }
    }

    void HandleHoverForce() 
    {
        float groundDifference = hoverHeight - currentGroundDistance;
        Vector3 finalHoverForce = Vector3.up * (1 + groundDifference);
        Debug.Log(groundDifference);
        RB.AddForce(finalHoverForce * weight);
    }

    void HandleTorque() 
    {
        RB.AddTorque(Vector3.up * torqueSpeed);
    }

    void HandleDrag() 
    {
        RB.drag = RB.velocity.magnitude * dragFactor;
    }
    #endregion
}
