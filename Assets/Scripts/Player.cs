using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rigidBody; // Referência ao componente RigidBody chamado de "rigidBody" 
    public float forca = 2000f;
    public float movimentoHorizontal = 500f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Sempre que se aplicam forças, segundo o Unity e o professor, deve-se usar o
    // "FixedUpdate()" e não o "Update()"
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, forca * Time.deltaTime); //adicionar uma força (eixo Z) para o cubo andar para a frente. A multiplicação referente ao "Time.deltaTime" serve com que a velocidade seja sempre a mesma, independentemente se o computador estiver sobrecarregado com programas abertos, por exemplo.

        if (Input.GetKey("d"))
        { //faz com que o "Player" se desloque para a direita
            rigidBody.AddForce(movimentoHorizontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //sem o force mode o player tem que ganhar 'balanço' e torna-se muito lento.
        }

        if (Input.GetKey("a"))
        { //faz com que o "Player" se desloque para a esquerda
            rigidBody.AddForce(-movimentoHorizontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //sem o force mode o player tem que ganhar 'balanço' e torna-se muito lento.
        }

        /** SERVIA PARA DAR RESTART NO JOGO CASO O USER CAISSE PARA ALEM DE -10, 
        * MAS COMO TEM AS BARREIRAS NÃO É PRECISO
        */
        // if(rigidBody.position.y < -10f){ 
        //     FindObjectOfType<GameManager>().GameOver();
        // }
    }
}
