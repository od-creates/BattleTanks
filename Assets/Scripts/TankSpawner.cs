using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _Tank;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_Tank, transform.position, Quaternion.identity);//tank spawner obj is at 0,0,0
    }
}
