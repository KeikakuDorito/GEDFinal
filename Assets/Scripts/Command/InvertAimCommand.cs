using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertAimCommand : ICommand
{

    public void Execute()
    {
        PlayerInputController.controller.InvertControls();
        Debug.Log("executed");
    }
}
