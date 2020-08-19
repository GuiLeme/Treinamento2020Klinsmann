using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLife : MonoBehaviour
{
    public Text vidaUI;
    public int vidaPersonagem;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        vidaUI.text = "Vida: " + vidaPersonagem.ToString();
        player.GetComponent<PlayerLife>().vida = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
