using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private bool isGameOver;
    private int playerHP = 150;
    public int Damage = 60;


    // Start is called before the first frame update
    void Start()
    {
        playerHP = playerHP - Damage;
        Debug.Log(playerHP);

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            if (playerHP <= 0)
            {
                Debug.Log("Te has quedado sin vida… GAME OVER");
            }

            if (playerHP < 30)
            {
                Debug.Log("Te has quedado sin vida… GAME OVER");
            }
            else
            {
                Debug.Log($"Vas bien de vida: tienes {playerHP} puntos de vida");
            }

        }
        else
        {
            Debug.Log("GAME OVER");
        }


    }
}
