using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguicao : MonoBehaviour
{
    // Será informado a posição do player
    public GameObject Player;

    
    // A movimentação irá seguir a posição do player atraves da atualização do frame

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Player.transform.position, Time.deltaTime);
    }
}
