using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    public static PlayerInputController controller;

    public GameControls inputAction {get; private set;}

    private void OnEnable() {
        inputAction.Enable();
    }

    private void OnDisable() {
        inputAction.Disable();
    }

    public void InvertControls()
    {
        inputAction.Player.Disable();
        inputAction.InvertedPlayer.Enable();
    }

    // Start is called before the first frame update
    void Awake()
    {
        if(controller == null)
        {
            controller = this;
        }

        inputAction = new GameControls();
    }
}
