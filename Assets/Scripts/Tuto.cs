using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tuto : MonoBehaviour
{
    public int current_tuto = 0; 
    public string tuto1, tuto2, tuto3;
    public Text text;

    private void Awake()
    {
    }

    void Start()
    {
        Time.timeScale = 0f;
        tuto1 = "Monsieur le maire, /n La situation dans Zoopolis se d�grade de jour en jour. Les gangs commencent � avoir la mainmise sur toute la ville, il nous faut r�agir. Utilisez tous les atouts � votre disposition pour les emp�cher de s'�tendre.";
        tuto2 = "Utilisez les forces de police pour �viter tout conflit entre les gangs et les emp�cher d��tendre leurs influences. Mettez des faux travaux � des endroits strat�giques pour bloquer certains passages.";
        tuto3 = "Certains chefs de gangs viendront vous voir parfois pour essayer de vous soudoyer. Faites bien attention � ce que vous r�pondez, certaines r�ponses pourront vous mettre des situations tr�s d�licates.";
    }

    public void NextTuto()
    {
        current_tuto++;
        if (current_tuto == 2)
        {
            text.text = tuto2;
        }
        else if (current_tuto == 3)
        {
            text.text = tuto3;
        }
        else if (current_tuto == 4)
        {
            Time.timeScale = 1f;
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        
    }
}
