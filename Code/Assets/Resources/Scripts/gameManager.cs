using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class gameManager : MonoBehaviour
{
    private static GameObject[] cartas;
    public  Sprite[] cartasFrente;
    private int cartasInstanciadas;
    public  List<int> myList = new List<int>();

    void Start()
    {
        Debug.Log("teste");
        cartasInstanciadas = 0;
        cartas = GameObject.FindGameObjectsWithTag("Cards");
        arrumarCartas();
        myList.Clear();
    }


    /// <summary>
    /// Método para sortear cartas aleatórias para serem instanciadas
    /// </summary>
    public void arrumarCartas()
    {
        while (cartasInstanciadas <= 18)
        {
            int numeroPosicao = Random.Range(0, cartas.Length);

            if (myList.Contains(numeroPosicao))
            {
                arrumarCartas();
            }
            else
            {
                cartas[cartasInstanciadas].GetComponent<button>().frenteCarta = cartasFrente[numeroPosicao];
                cartasInstanciadas += 1;
                myList.Add(numeroPosicao);
            }
        }
    }

}
