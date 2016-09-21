using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class button : MonoBehaviour
{
    public  bool clicado;
    public  Sprite frenteCarta;
    public Sprite versoCarta;

	void Update ()
    {
	    if (clicado)
        {
            //this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0f, -180f, 0f), 0.1f);

           // if (this.transform.eulerAngles.y >= 90f)
            //{
                this.GetComponent<Image>().sprite = frenteCarta;
            //}
        }

	}

    public void click()
    {
        if (detectar.pares.Length == 0 || detectar.pares.Length == 1)
        {
            clicado = true;
            this.gameObject.tag = "virado";
        }  
    }
}
