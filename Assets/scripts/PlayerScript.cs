using UnityEngine;
using Tmr;

public class PlayerScript : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        TimerDysplayScript.gameOver = true;
    }
}

