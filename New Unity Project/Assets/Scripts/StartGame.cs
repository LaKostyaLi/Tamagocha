using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject _buttonStart;
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private AudioClip _startMeow;

    public void OnButtonStartClick()
    {
        _audioSource.PlayOneShot(_startMeow);
        _buttonStart.SetActive(false);
    }
}
