using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMovementInput : MonoBehaviour
{
    [SerializeField] private Slider _speedSlider;
    [SerializeField] private CharacterModel _model;

    private void Start()
    {
        _speedSlider.onValueChanged.AddListener(InputSpeed);
        _model.OnChanged += OnModelChanged;
    }
    private void InputSpeed(float sliderValue) 
    { 
    var newSpeed = sliderValue * _model.MaxSpeed;
        if (newSpeed <= 0.1) 
        {
            newSpeed = 0;
        }
    _model.ChangeSpeed(newSpeed);
       
    }

    private void OnModelChanged()
    {


        var sliderValue = _model.Movementspeed / _model.MaxSpeed;

        if (sliderValue == _speedSlider.value) return;
        _speedSlider.value = sliderValue;

       
    }
}
