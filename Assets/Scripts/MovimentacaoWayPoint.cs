using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoWayPoint : MonoBehaviour
{
    // Lista com os objetos para referenciar as posições
    public GameObject[] locais;

    //Valor do index da lista para saber em qual posição está no momento
    public int index = 0;

    // Booleana indicando a se há movimentação
    public bool isMoving = true;

    // Update is called once per frame
    void Update()
    {

        if (isMoving)
        {
            // Deslocamento com MoveTowards para cada ponto no mundo colocado na lista
            transform.position = Vector3.MoveTowards(transform.position, locais[index].transform.position, 3 * Time.deltaTime);


            //Neste caso, assim que o objeto chegar no destino, irá passar para o proximo local da lista adicionado na lista

            if (transform.position == locais[index].transform.position)
            {
                if ((index + 1) != locais.Length)
                {
                    index += 1;

                }
                else
                {
                    isMoving = false;
                }
            }


        }

    }

}
