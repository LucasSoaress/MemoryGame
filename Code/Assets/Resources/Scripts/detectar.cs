using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class detectar : MonoBehaviour
{
    public static GameObject[] pares;
    private float tempoVirada;
    public Sprite verso;
   public static button b = new button();

    void Start ()
    {
        tempoVirada = 0;
    }
	
	void Update ()
    {
        pares = GameObject.FindGameObjectsWithTag("virado");
        

        if (pares.Length == 2)
        {
            tempoVirada += Time.deltaTime;
            if (pares[0].GetComponent<Image>().sprite.name == pares[1].GetComponent<Image>().sprite.name)
            {
                Debug.Log("acertei o par");
                trocarTag();
            }

            else if (tempoVirada >= 1)
            {
                pares[0].GetComponent<Image>().sprite = verso;
                pares[1].GetComponent<Image>().sprite = verso;
                b.clicado = false;
                Debug.Log("errei");
              //  pares[0].transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0f, 0f, 0f), 0.1f);
              //  pares[1].transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0f, 0f, 0f), 0.1f);
                // if (pares[0].transform.eulerAngles.y >= 90)
                // {
                     
                //}
                trocarTag();
                tempoVirada = 0;
            }
        }
    }

    void trocarTag()
    {
        pares[0].tag = "Player";
        pares[1].tag = "Player";
    }
}
