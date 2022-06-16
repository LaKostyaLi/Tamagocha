using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toilet : MonoBehaviour
{
    public Image _toiletBar;
    public float _fillToilet;

    public GameObject _poo;
    public GameManager _gmT;

    private void Start()
    {
        _fillToilet = 1f;
    }
    private void Update()
    {
        _fillToilet -= Time.deltaTime * 0.01f;
        _toiletBar.fillAmount = _fillToilet;

        if(_fillToilet>1f)
        {
            _fillToilet = 1f;
        }

        if(_fillToilet <0.015f)
        {
            _fillToilet = 0.015f;
        }
    }
}
