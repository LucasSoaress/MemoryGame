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
    public Sprite explicarLinguagensSprite;

    void Start ()
    {
        tempoVirada = 0;
        explicacao = explicacao.GetComponent<Image>();
        explicacao.enabled = false;
        botaoFechar.enabled = false;   
    }
	

    /// <summary>
    /// Verifica se as cartas clicadas são iguais e verifica qual o par de cartas clicadas, caso o par esteja correto
    /// </summary>
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

                pares[0].GetComponent<Button>().interactable = false;
                pares[1].GetComponent<Button>().interactable = false;
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

    /// <summary>
    /// Método para trocar a tag dos objetos que foram clicados
    /// </summary>
    /// <param name="tag">Define a tag</param>
    void trocarTag(string tag)
    {
        pares[0].tag = tag;
        pares[1].tag = tag;
    }

    /// <summary>
    /// Método para aparecer a imagem contendo a explicação
    /// </summary>
    /// <param name="position">Recebe um número que será a posição do array de imagens</param>
    void aparecerExplicacao(int position)
    {
        explicacao.enabled = true;
        explicacao.GetComponent<Image>().sprite = linguagemExplicacao[position];
        botaoFechar.enabled = true;
    }

    /// <summary>
    /// Fecha a tela de explicação
    /// </summary>
    public void fecharExplicacao()
    {
        explicacao.enabled = false;
        botaoFechar.enabled = false;
    }

    /// <summary>
    /// Exibe a tela mostrando o que são linguagens de programação
    /// </summary>
    public void explicarLinguagens()
    {
        explicacao.enabled = true;
        explicacao.GetComponent<Image>().sprite = explicarLinguagensSprite;
        botaoFechar.enabled = true;
    }

    
}
