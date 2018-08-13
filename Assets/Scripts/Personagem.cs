using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{

    private Rigidbody _rb;
    public float vel = 5f, tempoRotacao = 2f;

    public GameObject olhar;
    // 0 - Cima, 1 - Direita, 2 - Baixo, 3 - Esquerda, 4 - CimaDireita, 5 - BaixoDireita, 6 - BaixoEsquerda, 7 - CimaEsquerda
    public float[] rotacoesY;

    bool isRotacionando;

    public Alimento alimentoNaMao;

    // Use this for initialization
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        //olhar = transform.Find("Olhar").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    void FixedUpdate()
    {
        //Mover();
    }

    public void Mover ()
    {
        var y = Input.GetAxisRaw("Vertical");
        var x = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Vertical") || Input.GetButtonDown("Horizontal"))
        {
            StopAllCoroutines();
        }

        if (x > 0 && (y > -0.2f && y < 0.2f))
        {
            if (transform.rotation.y != rotacoesY[1])
            {
                StartCoroutine(Rotacionar(tempoRotacao, new Vector3(0, rotacoesY[1], 0)));
            }
        }
        else if (x < 0 && (y > -0.2f && y < 0.2f))
        {
            if (transform.rotation.y != rotacoesY[3])
            {
                StartCoroutine(Rotacionar(tempoRotacao, new Vector3(0, rotacoesY[3], 0)));
            }
        }
        else if (y > 0 && (x > -0.2f && x < 0.2f))
        {
            if (transform.rotation.y != rotacoesY[0])
            {
                StartCoroutine(Rotacionar(tempoRotacao, new Vector3(0, rotacoesY[0], 0)));
            }
        }
        else if (y < 0 && (x > -0.2f && x < 0.2f))
        {
            if (transform.rotation.y != rotacoesY[2])
            {
                StartCoroutine(Rotacionar(tempoRotacao, new Vector3(0, rotacoesY[2], 0)));
            }
        }

        if (x > 0 && y > 0)
        {
            if (transform.rotation.y != rotacoesY[4])
            {
                StartCoroutine(Rotacionar(tempoRotacao, new Vector3(0, rotacoesY[4], 0)));
            }
        }
        else if (x < 0 && y > 0)
        {
            if (transform.rotation.y != rotacoesY[7])
            {
                StartCoroutine(Rotacionar(tempoRotacao, new Vector3(0, rotacoesY[7], 0)));
            }

        }
        else if (x > 0 && y < 0)
        {
            if (transform.rotation.y != rotacoesY[5])
            {
                StartCoroutine(Rotacionar(tempoRotacao, new Vector3(0, rotacoesY[5], 0)));
            }
        }
        else if (x < 0 && y < 0)
        {
            if (transform.rotation.y != rotacoesY[6])
            {
                StartCoroutine(Rotacionar(tempoRotacao, new Vector3(0, rotacoesY[6], 0)));
            }
        }

        _rb.velocity = new Vector3(x * vel, _rb.velocity.y, y * vel);
    }

    public IEnumerator Rotacionar(float tempo, Vector3 posicao)
    {
        for (float i = 0; i < tempo; i += 0.01f)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(posicao), i / tempo);

            if (Input.GetButtonDown("Vertical") || Input.GetButtonDown("Horizontal"))
            {
                break;
            }

            yield return new WaitForSeconds(0.01f);
        }
        StopAllCoroutines();
    }

}
