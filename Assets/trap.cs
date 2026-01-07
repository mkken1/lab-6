using System;
using UnityEngine;

public class trap : MonoBehaviour
{
    [NonSerialized] public int damage = 30;
    [NonSerialized] public int heal = -100;
    private health playerHealth;
   
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trap: ловушка");
        playerHealth = other.GetComponent<health>();
        if (other.CompareTag("Player"))
        {
            if (playerHealth != null)
            {
                if (this.name=="bonus" || this.CompareTag("Bonus"))
                {
                    Debug.Log("trap: а нет");
                    playerHealth.TakeDamage(heal);
                    Debug.Log("trap: ам банан");
                    this.gameObject.SetActive(false);
                }
                else
                {
                    Debug.Log("trap: ай");
                    playerHealth.TakeDamage(damage);
                }
            }
            else
            {
                Debug.Log("trap: здоровья нет");
            }
        }
        else Debug.Log("trap: нет тега игрока");
    }
}
