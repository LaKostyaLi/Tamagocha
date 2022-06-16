using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptIcon : MonoBehaviour
{
    [SerializeField] private GameObject _bed;
    [SerializeField] private GameObject _kitchen;
    [SerializeField] private GameObject _toilet;

    [SerializeField] private GameObject _zzz;
    [SerializeField] private GameObject _up;
    [SerializeField] private GameObject _z;
    [SerializeField] private GameObject _faceGood;
    [SerializeField] private GameObject _faceSleep;

    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _milk;
    [SerializeField] AudioClip _korm;
    [SerializeField] AudioClip _hand;
    [SerializeField] AudioClip _sleep;

    public GameObject _iconPoo;
    public GameObject _iconKitchen;

    public Kitchen _kitch;
    public Bed _bedScript;
    public Toilet _toiletScript;
    public GameManager _gm;

    private bool _sleepButton=false;


    public bool _light = true; 


    public void OnClickBed()
    {
        _bed.SetActive(true);
        _kitchen.SetActive(false);
        _toilet.SetActive(false);  
    }

    public void OnClickKitchen()
    {
        _bed.SetActive(false);
        _kitchen.SetActive(true);
        _toilet.SetActive(false);
    }

    public void OnClickToilet()
    {
        _bed.SetActive(false);
        _kitchen.SetActive(false);
        _toilet.SetActive(true);
    }

    IEnumerator SleepCoroutine()
    {
        while (_sleepButton == true)
        {
            yield return new WaitForSeconds(3.5f);
            _audioSource.PlayOneShot(_sleep);
        }
    }
    public void OnClickedZZZ()
    {
        _light = false;

        if (_light == false)
        {
            _zzz.SetActive(false);
            _up.SetActive(true);
            _z.SetActive(false);
            _iconKitchen.SetActive(false);
            _iconPoo.SetActive(false);

            _audioSource.PlayOneShot(_sleep);

            _sleepButton = true;
            StartCoroutine(SleepCoroutine());
        }

        _bedScript._sleep = false;
    }

    public void OnClickedUp()
    {
        _light = true;
        _sleepButton = false;
        StopAllCoroutines();

        _iconKitchen.SetActive(true);
        _iconPoo.SetActive(true);

        if (_light == true)
        {
            _zzz.SetActive(true);
            _gm.GoodFace();

            _z.SetActive(true);
            _up.SetActive(false);

            _bedScript._sleep = true;
        }
    }

    public void OnClickMilk()
    {
        _audioSource.PlayOneShot(_milk);
        _kitch._fillKitchen += 0.35f;
    }

    public void OnClickKorm()
    {
        _audioSource.PlayOneShot(_korm);
        _kitch._fillKitchen += 0.35f;
    }

    public void OnClickHand()
    {
        _audioSource.PlayOneShot(_hand);
        _toiletScript._fillToilet += 0.9f;
    }
}
