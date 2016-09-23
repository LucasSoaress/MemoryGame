using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class detectar : MonoBehaviour
{
    public static GameObject[] pares;
    private float tempoVirada;
    public Sprite verso;
    public static button b = new button();
    private string nomeCartaUm;
    private string nomeCartaDois;

    public Image explicacao;
    public Sprite[] linguagemExplicacao;
    public Image botaoFechar;

    void Start ()
    {
        tempoVirada = 0;
        explicacao = explicacao.GetComponent<Image>();
        explicacao.enabled = false;
        botaoFechar.enabled = false;
    }
	
	void Update ()
    {
        pares = GameObject.FindGameObjectsWithTag("virado");
        
        if (pares.Length == 2)
        {
            nomeCartaDois = pares[1].GetComponent<Image>().sprite.name;
            nomeCartaUm = pares[0].GetComponent<Image>().sprite.name;

            tempoVirada += Time.deltaTime;

            if (nomeCartaUm == nomeCartaDois)
            {
                switch(nomeCartaUm)
                {
                    case "c#":
                        aparecerExplicacao(0);
                        break;
                    case "c":
                        aparecerExplicacao(1);
                        break;
                    case "java":
                        aparecerExplicacao(2);
                        break;
                    case"javascript":
                        aparecerExplicacao(3);
                        break;
                    case"pascal":
                        aparecerExplicacao(4);
                        break;
                    case"python":
                        aparecerExplicacao(5);
                        break;
                    case"php":
                        aparecerExplicacao(6);
                        break;
                    case"ruby":
                        aparecerExplicacao(7);
                        break;
                    case"lua":
                        aparecerExplicacao(8);
                        break;
                }
                trocarTag("Acertou");
            }

            else if (tempoVirada >= 1)
            {
                pares[0].GetComponent<Image>().sprite = verso;
                pares[1].GetComponent<Image>().sprite = verso;
                trocarTag("Player");
                tempoVirada = 0;
            }
        }
    }

    void trocarTag(string tag)
    {
        pares[0].tag = tag;
        pares[1].tag = tag;
    }

    void aparecerExplicacao(int position)
    {
        explicacao.enabled = true;
        explicacao.GetComponent<Image>().sprite = linguagemExplicacao[position];
        botaoFechar.enabled = true;
    }

    public void fecharExplicacao()
    {
        explicacao.enabled = false;
        botaoFechar.enabled = false;
    }
}
