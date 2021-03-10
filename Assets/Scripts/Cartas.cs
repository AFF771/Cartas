using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartas : MonoBehaviour
{
    string[] numero = new string[13] { "o Ás", "o Rei", "o Valete", "a Dama", "o Dez", "o Nove", "o Oito", "o Sete", "o Seis", "o Cinco", "o Quatro", "o Tres", "o Dois" };
    string[] nipe = { "Copas", "Ouros", "Espadas", "Paus" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Jogo: Baralho de Cartas.");
        Debug.Log("Pressiona a barra de espaços para retirar uma carta aleatória.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int posicaoNumero = Random.Range(1, 13);
            int posicaoNipe = Random.Range(1, 4);

            Debug.Log("Saiu " + numero[posicaoNumero] + " de " + nipe[posicaoNipe] + ".");

            Debug.Log("Pressiona a barra de espaço para retirar uma nova carta.");
        }
    }
}