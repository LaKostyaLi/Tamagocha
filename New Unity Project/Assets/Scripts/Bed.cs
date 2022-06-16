using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bed : MonoBehaviour
{
    public Image _bedBar;
    public float _fillBed;

    public bool _sleep = true;
    public GameManager _gmB;

    private void Start()
    {
        _fillBed = 1f;
    }

    private void Update()
    {
        if(_fillBed > 1f)
        {
            _fillBed = 1f;
        }

        if(_fillBed < 0.015f)
        {
            _fillBed = 0.015f;
        }

        if(_sleep == true)
        {
            _fillBed -= Time.deltaTime * 0.01f;
            _bedBar.fillAmount = _fillBed;
        }
        else
        {
            _fillBed += Time.deltaTime * 0.04f;
            _bedBar.fillAmount = _fillBed;
        }
    }
}
