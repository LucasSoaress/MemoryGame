using UnityEngine;
using System.Collections;

public class mudaCena : MonoBehaviour
{

	public void trocaCena(string cena)
    {
        Application.LoadLevel(cena);
    }

    public void sair()
    {
        Application.Quit();
    }
}
