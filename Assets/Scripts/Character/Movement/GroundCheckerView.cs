using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckerView : MonoBehaviour
{
    [SerializeField] private LayerMask _groundLayerMask;
    [SerializeField] private Transform _footsPosition;
    [SerializeField] private float _radius;
    [SerializeField] private CharacterModel _model;
    
    private void Start()
    {
        StartCoroutine(Checking());
    }
    public IEnumerator Checking()
    {
        while (true)
        {
            Ray ray = new Ray(_footsPosition.position, Vector3.down);




            var isGround = Physics.Raycast(ray, _radius, _groundLayerMask);

            _model.ChangeGround(isGround);

            yield return new WaitForSeconds(.2f);
        }

    }

}
