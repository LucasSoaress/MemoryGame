using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class button : MonoBehaviour
{
    public  Sprite frenteCarta;
    public Sprite versoCarta;

    public void click()
    {
        if (this.gameObject.tag == "Player" || this.gameObject.tag == "Cards")
        {
            if (detectar.pares.Length == 0 || detectar.pares.Length == 1)
            {
                this.GetComponent<Image>().sprite = frenteCarta;
                this.gameObject.tag = "virado";
            } 
        }
         
    }
}
