using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class AnimacaoController : MonoBehaviour
{
    private Animator _anim;

    private Rigidbody _playerRb;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
    }
}
