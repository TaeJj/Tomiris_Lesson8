using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarView : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private CharacterModel _model;
    [SerializeField] private float _fillSpeed = 1;

    private float _healthPercentage => ((float)_model.Healthpoints / (float)_model.MaxHealthpoint);


    private void Update()
    {
        _healthBar.value = Mathf.Lerp(_healthBar.value, _healthPercentage, Time.deltaTime * _fillSpeed);
    }
       
    
        



  

}
