using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveComCurvas : MonoBehaviour
{

    public AnimationCurve curvaAtaque;
    public AnimationCurve curvaRelease;
    Vector2 input;
    Rigidbody2D rb;
    public float forcaFogueteX;
    public float forcaFogueteY;
    public Vector2 velocidade;
    float timerEsq, timerDir, timerBaixo,
        inputDir, inputEsq, inputBaixo;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();		
    }

    /// <summary>
    /// Os diferentes timers são usados para consultar a curva adequada definida no inspetor.
    /// Quando o input está pressionado, é a curva de ataque.
    /// Quandoe stá solto, é a de release. Isso poderia ser refeito como uma única função / classe / coroutine reutilizável para cada input.
    /// </summary>
    void Update()
    {
        timerEsq += Time.deltaTime;
        timerDir += Time.deltaTime;
        timerBaixo += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            timerEsq = 0;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            timerEsq = 0f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            timerDir = 0;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            timerDir = 0f;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            timerBaixo = 0;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            timerBaixo = 0f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            inputEsq = curvaAtaque.Evaluate(timerEsq);
        }
        else
        {
            inputEsq = curvaRelease.Evaluate(timerEsq);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            inputDir = curvaAtaque.Evaluate(timerDir);
        }
        else
        {
            inputDir = curvaRelease.Evaluate(timerDir);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            inputBaixo = curvaAtaque.Evaluate(timerBaixo);
        }
        else
        {
            inputBaixo = curvaRelease.Evaluate(timerBaixo);
        }

    }

    /// <summary>
    /// Versão da função utilizando as curvas de ataque e release, usando o timer para cada input 
    /// e puxando as duração e intensidade da variável da curva do inspetor.
    /// </summary>
    void FixedUpdate()
    {
        Vector2 velocidadeNova = Vector2.zero;
        velocidadeNova.x = (-1 * inputEsq + inputDir) * forcaFogueteX * Time.fixedDeltaTime;
        velocidadeNova.y = inputBaixo * forcaFogueteY * Time.fixedDeltaTime;
        rb.velocity += velocidadeNova;
    }
}

