using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    private Rigidbody _rb;

    [SerializeField]
    private float _vel = 5f, _velRotacao = 10f;

    [SerializeField]
    private Objeto _objetoNaMao;

    [SerializeField]
    public KeyCode botaoInteracao = KeyCode.F;

    public Objeto ObjetoNaMao
    {
        get
        {
            return _objetoNaMao;
        }

        set
        {
            _objetoNaMao = value;
        }
    }

    public float Vel
    {
        get
        {
            return _vel;
        }

        set
        {
            _vel = value;
        }
    }

    public float VelRotacao
    {
        get
        {
            return _velRotacao;
        }

        set
        {
            _velRotacao = value;
        }
    }

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Mover();
    }

    public void Mover()
    {
        var y = Input.GetAxis("Vertical");
        var x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Vertical") || Input.GetButtonDown("Horizontal"))
        {
            StopAllCoroutines();
            
        }
        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
        {
            Rotacionar();

            _rb.velocity = new Vector3(x * Vel, _rb.velocity.y, y * Vel);
        }


    }

    public void Rotacionar()
    {
        Vector3 direcao = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")), dirRaw = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        if (direcao.sqrMagnitude > 1)
        {
            direcao.Normalize();
        }

        if (dirRaw.sqrMagnitude > 1)
        {
            dirRaw.Normalize();
        }

        if (dirRaw != Vector3.zero)
        {
            var rotacao = Quaternion.LookRotation(direcao).eulerAngles;

            _rb.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rotacao.x, Mathf.Round(rotacao.y / 45) * 45, rotacao.z), Time.deltaTime * VelRotacao);

        }
    }
}
