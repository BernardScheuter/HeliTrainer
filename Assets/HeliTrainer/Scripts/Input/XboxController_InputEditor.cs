﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using CantThinkOfAName;

[CustomEditor(typeof(Input_XboxController))]
public class XboxController_Input : Editor
{
    #region Variables
    Input_XboxController targetInput;
    #endregion

    #region Builtin Methods
    private void OnEnable()
    {
        targetInput = (Input_XboxController)target;

    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        DrawDebugUI();
        Repaint();
    }
    #endregion

    #region Custom Methods
    void DrawDebugUI()
    {
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        EditorGUILayout.Space();


        EditorGUI.indentLevel++;
        EditorGUILayout.LabelField("Throttle: " + targetInput.ThrottleInput.ToString("0.00"), EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Collective: " + targetInput.CollectiveInput.ToString("0.00"), EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Cyclic: " + targetInput.CyclicInput.ToString("0.00"), EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Pedal: " + targetInput.PedalInput.ToString("0.00"), EditorStyles.boldLabel);

        EditorGUILayout.EndVertical();
    }
    #endregion
}