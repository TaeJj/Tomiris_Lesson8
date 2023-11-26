using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView : MonoBehaviour
{
    [SerializeField] private CharacterModel _model;
    [SerializeField] private Animator animator;
   


    public void Walk()
    {
        var walkSpeed = _model.MaxSpeed * 0.4f;
        _model.ChangeSpeed(walkSpeed);
    }

    public void Run()
    {
        var runSpeed = _model.MaxSpeed * 0.6f;
        _model.ChangeSpeed(runSpeed);
    }

    public void Jump()
    {
        if (_model.OnGround)
        {
            animator.SetBool("Jump", true);

        }
    }


    public void GetDamage()
    {
        var newHealth = _model.Healthpoints - 10;
        _model.ChangeHealth(newHealth);

    }

    
}
