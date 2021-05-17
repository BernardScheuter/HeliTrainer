using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CantThinkOfAName
{
    public class Heli_Camera : MonoBehaviour, IHeli_Camera
    {
        #region Variables
        [Header("Camera Properties")]
        public Rigidbody rb;
        public Transform lookAtTarget;

        public float height = 2f;
        public float distance = 2f;
        public float smoothSpeed = .35f;
        private Vector3 wantedPos;
        private Vector3 refVelocity;

        #endregion

        #region Builtin Methods
        void FixedUpdate()
        {
            if (rb)
            {
                UpdateCamera();
            }
        }
        #endregion

        #region Interface Methods
        public void UpdateCamera()
        {
            //Debug.Log("Camera is Updating");
            Vector3 flatfwd = rb.transform.forward;
            flatfwd.y = 0f; // zet de y waarde op nul zodat de camera horizontaal blijft
            flatfwd = flatfwd.normalized; // zorgt er voor dat de lengte 1 blijft

            //wanted position
            wantedPos = rb.position + (flatfwd * distance) + (Vector3.up * height);

            //lets position the camera
            transform.position = Vector3.SmoothDamp(transform.position, wantedPos, ref refVelocity, smoothSpeed);
            transform.LookAt(lookAtTarget);
        }
        #endregion
    }
}