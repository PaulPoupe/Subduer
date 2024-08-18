using System;
using UnityEngine;

public class KeyEventBus : MonoBehaviour
{
    public static event Action OnEscape;

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            OnEscape?.Invoke();

    }
}