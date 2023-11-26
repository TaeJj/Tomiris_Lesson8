using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _gameObject;
    

    private bool _enabled = false;  
    void Start()
    {
        _button.onClick.AddListener(DisableObject);
    }

    
   public void DisableObject(GameObject gameObject)
    {
        _enabled ^= true;

        gameObject.SetActive(_enabled);
    }

    public void DisableObject()
    {
        gameObject.SetActive(false);
    }

}
