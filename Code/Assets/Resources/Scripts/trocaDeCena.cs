using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class trocaDeCena : MonoBehaviour
{
    public Canvas error404;
    public Canvas error405;
    public float tempoError;

    void Start()
    {
        tempoError = 0;
        error404.enabled = false;
        error405.enabled = false;
    }


    /// <summary>
    /// Some com os canvas
    /// </summary>
    void Update()
    {
        tempoError += 1 * Time.deltaTime;
       
        if (tempoError >= 5)
        {
            error404.enabled = false;
            error405.enabled = false;
        }

    }

    /// <summary>
    /// Método para trocar entre cenas
    /// </summary>
    /// <param name="nomeDaCena">Recebe uma string para ser o nome da cena</param>
    public void carregarCena(string nomeDaCena)
    {
        Application.LoadLevel(nomeDaCena);
    }

    /// <summary>
    /// Método para fechar o jogo
    /// </summary>
    public void sair()
    {
        Application.Quit();
    }

    /// <summary>
    /// Abre a tela de créditos
    /// </summary>
    public void abrirError404()
    {
        error404.enabled = true;
        tempoError = 0;
    }

    /// <summary>
    /// Abre a tela de sobre
    /// </summary>
    public void abrirError405()
    {
        error405.enabled = true;
        tempoError = 0;
    }
}
