using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class AnimatorStateView : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] CharacterModel _model;

    private void Start()
    {
        _model.OnChanged += OnStateChanged;
    }
    
    private void OnStateChanged ()

    {
        var animationSpeed = _model.Movementspeed / _model.MaxSpeed;
        animator.SetFloat("MovementSpeed", animationSpeed);
        if (_model.OnGround)
        {
            animator.SetBool("Jump", false);
        }

    }
 }