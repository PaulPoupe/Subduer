using System;
using UnityEngine;

public class UIGameManager : MonoBehaviour
{
    public static event Action Escape;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Escape?.Invoke();
        }
    }
}