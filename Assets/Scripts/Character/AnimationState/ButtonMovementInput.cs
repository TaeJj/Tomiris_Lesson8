using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))] 
public class ButtonMovementInput : MonoBehaviour
{
    [SerializeField] private MovementState _animationKey;
    private Button _button;
    public event Action<MovementState> OnKeyInputed;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Input);
    }

    private void Input()
    {
        OnKeyInputed.Invoke(_animationKey);
    }


}
