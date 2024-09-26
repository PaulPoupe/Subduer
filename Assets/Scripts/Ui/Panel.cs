using System;
using UnityEngine;

public abstract class Panel : MonoBehaviour
{
    protected bool isExternalPanel;
    protected event Action OnClose;

    public virtual void Initialize(bool isExternalPanel)
    {
        this.isExternalPanel = isExternalPanel;
        Subscribe();
    }

    public virtual void Initialize(bool isExternalPanel, Panel chiledPanel) => Initialize(isExternalPanel);

    protected abstract void Subscribe();
    public abstract void UnSubscribe();

    public void Open()
    {
        if (!gameObject.activeInHierarchy)
            gameObject.SetActive(true);

        else
            Close();
    }

    public void Close()
    {
        if (gameObject != null && gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
            OnClose?.Invoke();
        }
    }
}