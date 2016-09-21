using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class gameManager : MonoBehaviour
{
    private static GameObject[] cartas;
    public  Sprite[] cartasFrente;
    private int cartasInstanciadas;
    public static List<int> myList = new List<int>();

    void Awake()
    {
        cartasInstanciadas = 0;
        cartas = GameObject.FindGameObjectsWithTag("Cards");
        arrumarCartas();
    }
   
    void arrumarCartas()
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
