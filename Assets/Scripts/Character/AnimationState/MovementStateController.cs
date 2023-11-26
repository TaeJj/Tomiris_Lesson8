using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStateController : MonoBehaviour

{
    [SerializeField] List<ButtonMovementInput> _buttons;
    [SerializeField] CharacterView _view;
    private void OnStateChanged(MovementState animatorStates)
    {

        switch (animatorStates)
        {
            case MovementState.Walk:
                _view.Walk();
                break;
            case MovementState.Run:
                _view.Run();
                break;
            case MovementState.Jump:
                _view.Jump();
                break;
         
        }
    }
    private void Start()
    {
        foreach (var button in _buttons)
        {
            button.OnKeyInputed += OnStateChanged;
        }
    }
}
