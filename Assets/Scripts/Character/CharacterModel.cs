using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{

    [field: SerializeField] public int MaxHealthpoint { get; private set; }
    [field: SerializeField] public int Healthpoints { get; private set; }
    [field: SerializeField] public float Movementspeed {  get; private set; }
    [field: SerializeField] public bool OnGround  { get; private set; }
    [field: SerializeField, Range(5, 10)] public float MaxSpeed { get; private set; }


    private void Start()
    {
        Healthpoints = MaxHealthpoint;

    }
    public event Action OnChanged;

    public void ChangeSpeed(float newSpeed)
    {
        if (newSpeed >= MaxSpeed) return;
        if (newSpeed == Movementspeed) return;

        Movementspeed = newSpeed;
        OnChanged?.Invoke();
        
    }

    public void ChangeHealth(int newHealth)
    {
        if (newHealth < 0) return;
        if (newHealth == Healthpoints) return;

        Healthpoints = newHealth;
        OnChanged?.Invoke();
    }

    public void ChangeGround(bool newGround)
    {
        if (newGround == OnGround) return;
       
        OnGround = newGround;
        OnChanged?.Invoke();
        
    }
}
