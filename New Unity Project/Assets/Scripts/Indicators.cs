using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indicators : MonoBehaviour
{
    [SerializeField] private Image _eatBar;
    [SerializeField] private Image _bedBar;
    [SerializeField] private Image _toiletBar;



    public float _eatAmount = 100;
    public float _bedAmount = 100;
    public float _toiletAmount = 100;

    //private float _secondsToEmptyEat=10f;
    private float _secondsToEmptyBed=500f;
    private float _secondsToEmptyToilet=700f;

    private void Start()
    {
        _eatBar.fillAmount = _eatAmount / 100;
        _bedBar.fillAmount = _bedAmount / 100;
        _toiletBar.fillAmount = _toiletAmount / 100;
    }

    private void Update()
    {
        if(_eatAmount>0)
        {
            //_eatAmount -= 100 / _secondsToEmptyEat * Time.deltaTime;
            _eatAmount -= Time.deltaTime;
            _eatBar.fillAmount = _eatAmount / 100;
        }

        if (_bedAmount>0)
        {
            _bedAmount -= 100 / _secondsToEmptyBed * Time.deltaTime;
            _bedBar.fillAmount = _bedAmount / 100;
        }

        if(_toiletAmount>0)
        {
            _toiletAmount -= 100 / _secondsToEmptyToilet * Time.deltaTime;
            _toiletBar.fillAmount = _toiletAmount / 100;
        }
    }
}
