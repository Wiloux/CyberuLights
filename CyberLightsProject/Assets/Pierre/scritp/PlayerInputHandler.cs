using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    private Mover mover;

    private void Awake()
    {
        mover = GetComponent<Mover>();
    }


    // Update is called once per frame
    public void OnMove(CallbackContext context) 
    {
        mover.SetInputVector(context.ReadValue<Vector2>());
    }

    public void OnJump(CallbackContext context)
    {
        mover.Jump();
    }
}
