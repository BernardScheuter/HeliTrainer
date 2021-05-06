using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CantThinkOfAName;

    public class testScript : MonoBehaviour
    {
        public Input_Keyboard input;
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        float throttleInput = input.ThrottleInput;
        Debug.Log(throttleInput);
        }
    }
