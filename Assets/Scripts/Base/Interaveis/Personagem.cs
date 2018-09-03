using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Classe base para os Personagens. Essa classe contém funções e algoritmos genéricos que todos os personagens usarão.
/// Apesar de não ser uma classe abstrata, não é recomendável instanciar esta classe, ela serve apenas como base.
/// </summary>
public class Personagem : MonoBehaviour
{
    /// <summary>
    /// Referencia à fisica do personagem.
    /// </summary>
    private Rigidbody _rb;
    /// <summary>
    /// Referência ao animator do personagem.
    /// </summary>
    private Animator _anim;

    [Tooltip("Campo usado para verificar o número do Jogador, se será Player 1, 2, 3, etc.")]
    public int numeroJogador = 1;

    [Header("Configurações")]
    [SerializeField]
    private float _vel = 5f;
    private float _velRotacao = 10f;

    [Header("Interação")]
    [SerializeField]
    private Objeto _objetoNaMao;

    [SerializeField]
    public KeyCode botaoInteracao = KeyCode.F;

    [Header("Input")]
    [SerializeField]
    private string _axisHorizontal = "", _axisVertical = "";

    /// <summary>
    /// Propriedade responsável pelo encapsulamento do campo '_objetoNaMao'.
    /// </summary>
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
    /// <summary>
    /// Propriedade responsável pelo encapsulamento do campo '_vel'.
    /// </summary>
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
    /// <summary>
    /// Propriedade responsável pelo encapsulamento do campo '_velRotacao'.
    /// </summary>
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

    /// <summary>
    /// Instancia dos campos no começo da execução da Cena.
    /// </summary>
    protected virtual void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }

    /// <summary>
    /// Método FixedUpdate para verificação de cada quadro
    /// </summary>
    protected virtual void FixedUpdate()
    {
        Mover();
    }

    /// <summary>
    /// Responsável pela movimentação.
    /// </summary>
    public virtual void Mover()
    {
        //Pega os valores de Axis.
        var y = Input.GetAxis(_axisVertical);
        var x = Input.GetAxis(_axisHorizontal);

        //Verifica se o jogador está apertando algum Axis.
        if (Input.GetButton(_axisHorizontal) || Input.GetButton(_axisVertical))
        {
            //Aciona a animação.
            _anim.SetFloat("Move", 1);
            //Rotaciona o jogador.
            Rotacionar();
            //Movimenta o jogador na direção em que os Axis estiverem apontando.
            _rb.velocity = new Vector3(x * Vel, _rb.velocity.y, y * Vel);
        }else
        {
            //Caso não esteja apertando nada, para a animação.
            _anim.SetFloat("Move", 0);
        }
    }

    /// <summary>
    /// Rotaciona o objeto para olhar em direção ao ponto que o jogador escolher.
    /// </summary>
    public virtual void Rotacionar()
    {
        // Pega a direção que os Axis estão apontando
        Vector3 direcao = new Vector3(Input.GetAxis(_axisHorizontal), 0, Input.GetAxis(_axisVertical)); //Essa é a direção em valor Smoothed.
        Vector3 dirRaw = new Vector3(Input.GetAxisRaw(_axisHorizontal), 0, Input.GetAxisRaw(_axisVertical)); // Essa aqui é a direção em valor bruto.

        //Verifica se o comprimento quadrado da direção Smoothed. Caso seja maior que 1, ele normaliza essa direção.
        if (direcao.sqrMagnitude > 1)
        {
            direcao.Normalize();
        }

        //Verifica se o comprimento quadrado da direção Bruta. Caso seja maior que 1, ele normaliza essa direção.
        if (dirRaw.sqrMagnitude > 1)
        {
            dirRaw.Normalize();
        }

        //Verifica se a direção bruta for diferente de um vetor Zero
        if (dirRaw != Vector3.zero)
        {
            //Caso seja, cria um EulerAngles com a direção que a direção normalizada Smoothed está olhando.
            var rotacao = Quaternion.LookRotation(direcao).eulerAngles;

            //Rotaciona o objeto, de maneira suavizada (Slerp) da rotação atual para a direção criada, em uma velocidade de rotação definida.
            _rb.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rotacao.x, Mathf.Round(rotacao.y / 45) * 45, rotacao.z), Time.deltaTime * VelRotacao);
        }
    }
}
