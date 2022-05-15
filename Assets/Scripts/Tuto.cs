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
        tuto1 = "Monsieur le maire, /n La situation dans Zoopolis se dégrade de jour en jour. Les gangs commencent à avoir la mainmise sur toute la ville, il nous faut réagir. Utilisez tous les atouts à votre disposition pour les empêcher de s'étendre.";
        tuto2 = "Utilisez les forces de police pour éviter tout conflit entre les gangs et les empêcher d’étendre leurs influences. Mettez des faux travaux à des endroits stratégiques pour bloquer certains passages.";
        tuto3 = "Certains chefs de gangs viendront vous voir parfois pour essayer de vous soudoyer. Faites bien attention à ce que vous répondez, certaines réponses pourront vous mettre des situations très délicates.";
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
