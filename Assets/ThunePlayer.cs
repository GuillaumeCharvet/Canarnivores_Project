using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThunePlayer : MonoBehaviour
{
    public int playerGold = 50, revenu = 10;
    public float cdGold = 1f;
    public float cdGoldMax = 1f;

    public Text textGold;

    private void Start()
    {
        textGold = GameObject.FindGameObjectWithTag("TextMoney").GetComponent<Text>();
    }

    private void Update()
    {
        cdGold -= Time.deltaTime;

        if (cdGold <= 0f)
        {
            cdGold = cdGoldMax;
            playerGold += revenu;
            textGold.text = " $ " + playerGold;
        }
    }
}
