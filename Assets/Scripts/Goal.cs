using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        string goalName = transform.name;
        if(hitInfo.name == "EnergyBall") 
        {
            hitInfo.gameObject.SendMessage("Regame", SendMessageOptions.RequireReceiver);

            GameManager.instance.Scoring(goalName);
        }
    }
}
