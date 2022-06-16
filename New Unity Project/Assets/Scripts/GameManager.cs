using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _faceG;
    [SerializeField] private GameObject _faceAngry;
    [SerializeField] private GameObject _faceSleep;

    public GameObject _poo;

    public Kitchen _k;
    public Toilet _t;
    public Bed _b;

    public ScriptIcon _si;

    private void Update()
    {
        if(_k._fillKitchen<0.2 || _t._fillToilet<0.2 || _b._fillBed <0.2)
        {
            AngryFace();
        }
        else
        {
            GoodFace();
        }
        //сонная мордочка
        if(_si._light==false)
        {
            SleepFace();
        }
        //какашка
        if(_t._fillToilet<0.2)
        {
            _poo.SetActive(true);
        }
        else
        {
            _poo.SetActive(false);
        }
    }
    public void AngryFace()
    {
        _faceG.SetActive(false);
        _faceAngry.SetActive(true);
        _faceSleep.SetActive(false);
    }

    public void GoodFace()
    {
        _faceG.SetActive(true);
        _faceAngry.SetActive(false);
        _faceSleep.SetActive(false);
    }

    public void SleepFace()
    {
        _faceSleep.SetActive(true);
        _faceAngry.SetActive(false);
        _faceG.SetActive(false);
    }
}
