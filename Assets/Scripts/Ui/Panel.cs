using System;
using UnityEngine;

public abstract class Panel : MonoBehaviour
{
    protected event Action OnClose;

    public abstract void Initialize();


    public void Open()
    {
        if (!gameObject.activeInHierarchy)
            gameObject.SetActive(true);

        else
            Close();
    }

    public void Close()
    {
        if (gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
            OnClose?.Invoke();
        }
    }

    private void OnDestroy() => UnSubscribe();

    protected abstract void UnSubscribe();
}