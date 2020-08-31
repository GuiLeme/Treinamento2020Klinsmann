using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            Atack();
        }
    }
    void Atack()
    {
        //fazer a animação
        //ver se tem alguém no range do ataque
        //ver qual o inimigo que será atacado
    }
}
