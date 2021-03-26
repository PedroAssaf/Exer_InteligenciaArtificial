using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{

    // A movimentação é utilizada atraves da função de Lerp, tendo um refinamento em sua chegada
    // Sai do ponto inicial e finaliza nas coordenadas 5,1,4 do mundo.

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(5, 1, 4), Time.deltaTime);
    }
}
