using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkbenchMenuInput : MonoBehaviour, IWorkbenchMenuInput
{
    [SerializeField] VRButton upButton;
    [SerializeField] VRButton downButton;
    [SerializeField] VRButton leftButton;
    [SerializeField] VRButton rightButton;

    [Space]
    [SerializeField] VRButton enterButton;

    public void Up()
    {
        throw new NotImplementedException();
    }
    public void Down()
    {
        throw new NotImplementedException();
    }
    public void Left()
    {
        throw new NotImplementedException();
    }

    public void Right()
    {
        throw new NotImplementedException();
    }
    public void Enter()
    {
        throw new NotImplementedException();
    }

    void OnEnable()
    {
        upButton.Pressed += Up;
        downButton.Pressed += Down;
        leftButton.Pressed += Left;
        rightButton.Pressed += Right;
        enterButton.Pressed += Enter;
    }
}
