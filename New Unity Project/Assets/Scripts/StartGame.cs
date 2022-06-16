using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject _tamogocha;

    [SerializeField] private GameObject _buttonStart;
    [SerializeField] private GameObject _indicators;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _z;

    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private AudioClip _startMeow;


    public void OnButtonStartClick()
    {
        //Instantiate(_tamogocha, new Vector3 (0,0,0) , Quaternion.identity);
        _audioSource.PlayOneShot(_startMeow);
        _buttonStart.SetActive(false);
        _indicators.SetActive(true);
        _player.SetActive(true);
        _z.SetActive(true);
    }
}
