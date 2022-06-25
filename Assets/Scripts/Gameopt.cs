using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    bool gamewin = true;
    bool gamelose = false;

    void Gameoption()
    {
        if (gamewin == true)
        {
            print("You win the game");
        }
        else
        {
            print("You lose the game");
        }
    }

    void Start()
    {
        Gameoption();
    }
}
