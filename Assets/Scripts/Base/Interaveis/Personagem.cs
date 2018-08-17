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

    [SerializeField]
    private string _axisHorizontal, _axisVertical;


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
        var y = Input.GetAxis(_axisVertical);
        var x = Input.GetAxis(_axisHorizontal);

        if (Input.GetButtonDown(_axisHorizontal) || Input.GetButtonDown(_axisVertical))
        {
            StopAllCoroutines();
            
        }
        if (Input.GetButton(_axisHorizontal) || Input.GetButton(_axisVertical))
        {
            Rotacionar();

            _rb.velocity = new Vector3(x * Vel, _rb.velocity.y, y * Vel);
        }
    }

    public void Rotacionar()
    {
        Vector3 direcao = new Vector3(Input.GetAxis(_axisHorizontal), 0, Input.GetAxis(_axisVertical)), dirRaw = new Vector3(Input.GetAxisRaw(_axisHorizontal), 0, Input.GetAxisRaw(_axisVertical));

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
