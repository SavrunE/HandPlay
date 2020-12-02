using System;
using UnityEngine;
using UnityEngine.UI;

public class ModulePresenter : MonoBehaviour
{
    [SerializeField] Text lable;
    [SerializeField] Toggle toggle;

    Action<bool> onToggle;
    void OnEnable()
    {
        toggle.onValueChanged.AddListener(OnToggle);
    }
    void OnDisable()
    {
        toggle.onValueChanged.RemoveListener(OnToggle);
    }

    public void Present(IModule module, Action<bool> onToggle)
    {
        lable.text = module.Name;
        this.onToggle = onToggle;
    }
    void OnToggle(bool value)
    {
        onToggle?.Invoke(value);
    }
}
