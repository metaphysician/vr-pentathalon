using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncherBehavior : MonoBehaviour
{

    void Start()
    {
        
    }
    [SerializeField] GameObject _launchPoint;
    [SerializeField] GameObject _rocketPrefab;
    [SerializeField] GameObject _rocketClone;
    [SerializeField] GameObject _rocketStatic;

    private bool _fired = false;

    [ContextMenu("TestFire")]
    public void FireRocket()
    {
        _rocketClone = GameObject.Instantiate(_rocketPrefab,_launchPoint.transform.position,_launchPoint.transform.rotation);
        _rocketStatic.SetActive(false);
        _fired = true;
    }

    void Update()
    {
        if(_rocketClone)
        {}
        else if(!_rocketClone && _fired)
        {
          _rocketStatic.SetActive(true);
          _fired = false;  
        }
    }

}
