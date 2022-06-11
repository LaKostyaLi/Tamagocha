using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptIcon : MonoBehaviour
{
    [SerializeField] private GameObject _bed;
    [SerializeField] private GameObject _kitchen;
    [SerializeField] private GameObject _toilet;


    public void OnClickBed()
    {
        _bed.SetActive(true);
        _kitchen.SetActive(false);
        _toilet.SetActive(false);  
    }

    public void OnClickKitch()
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
}
