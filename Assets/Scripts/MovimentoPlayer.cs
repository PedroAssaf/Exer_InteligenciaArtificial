using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
   
    // Movimentação do personagem atraves dos botões WASD

    // Update is called once per frame
    void Update()
    {
        // Ao pressionar o botão W o player se movimenta para frente

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 5f);
        }

        // Ao pressionar o botão S o player se movimenta para trás
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 5f);
        }

        // Ao pressionar o botão A o player se movimenta para esquerda
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5f);
        }

        // Ao pressionar o botão D o player se movimenta para direto
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5f);
        }
    }
}
