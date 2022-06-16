using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kitchen : MonoBehaviour
{
    public Image _barKitchen;
    public float _fillKitchen;
    public GameManager _gm;

    private void Start()
    {
        _fillKitchen = 1f;
    }

    private void Update()
    {
        if(_fillKitchen>1f)
        {
            _fillKitchen = 1f;
        }

        if (_fillKitchen < 0.015f)
        {
            _fillKitchen = 0.015f;
        }

        _fillKitchen -= Time.deltaTime*0.01f;
        _barKitchen.fillAmount = _fillKitchen;
    }
}
