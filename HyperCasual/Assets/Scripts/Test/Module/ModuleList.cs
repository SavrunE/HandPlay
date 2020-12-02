using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleList : MonoBehaviour
{
    [SerializeField] private ModulePresenter template;
    [SerializeField] private Transform container;
    private void Awake()
    {
        foreach (var module in ModulesLoader.GetAll())
        {
            var presenter = Instantiate(template, container) as ModulePresenter;
            //presenter.
        }
    }
}
