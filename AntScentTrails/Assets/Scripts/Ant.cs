using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ant : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationVariance;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 359));
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.forward* Random.Range(transform.rotation.z - _rotationVariance, transform.rotation.z + _rotationVariance));
        //transform.rotation.SetFromToRotation(transform.rotation, Quaternion.Euler(0, 0, Random.Range(transform.rotation.z, transform.rotation.z + _rotationVariance)));
        _rb.velocity = transform.up * (_speed * Time.deltaTime);
    }
}
