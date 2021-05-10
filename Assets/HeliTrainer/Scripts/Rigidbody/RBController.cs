using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CantThinkOfAName
{
    [RequireComponent(typeof(Rigidbody))]
    public class RBController : MonoBehaviour
    {
        #region Variables
        [Header("Base Properties")]
        public Transform COG;
        protected Rigidbody RB;
        #endregion

        #region BuiltIn Methods

        // Start is called before the first frame update
        public virtual void Start()
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
}