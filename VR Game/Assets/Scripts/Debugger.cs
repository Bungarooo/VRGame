using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Debugger : MonoBehaviour
{
    public int gridSize = 10;
    public float gridSpacing = 1;

    private void OnRenderObject()
    {
        /*
        Material material = new Material(Shader.Find("Hidden/Internal-Colored"));
        material.SetPass(0);

        GL.PushMatrix();
        GL.MultMatrix(transform.localToWorldMatrix);

        GL.Begin(GL.LINES);
        GL.Color(Color.white);
        for (int i = 0; i <= gridSize; i++)
        {
            // Draw horizontal lines
            GL.Vertex3(0f - gridSize * 0.5f * gridSpacing, 0f, (i - gridSize * 0.5f) * gridSpacing);
            GL.Vertex3(gridSize * 0.5f * gridSpacing, 0f, (i - gridSize * 0.5f) * gridSpacing);

            // Draw vertical lines
            GL.Vertex3((i - gridSize * 0.5f) * gridSpacing, 0f, 0f - gridSize * 0.5f * gridSpacing);
            GL.Vertex3((i - gridSize * 0.5f) * gridSpacing, 0f, gridSize * 0.5f * gridSpacing);
        }
        GL.End();

        GL.PopMatrix();
        */
    }
}
