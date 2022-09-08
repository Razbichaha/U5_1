using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 2;
    private int _revers = -1;
    private SpriteRenderer _renderer;
    private Animator _animator;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * _revers, 0, 0);
            _renderer.flipX = true;
            _animator.SetBool("isRuning", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            _animator.SetBool("isRuning", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _renderer.flipX = false;
            _animator.SetBool("isRuning", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            _animator.SetBool("isRuning", false);
        }
    }
}
