using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //Daño de ataque
    public int attackEnemy = 5;

    // Colisión del enemigo
    private Collider biteCollider;

    // Sonido de ataque
    public Sound enemyHit;

    // Start is called before the first frame update
    void Start()
    {
        biteCollider = GetComponent<Collider>();
    }

    //Si el arma colisiona con el jugador, le resta vida y se reproduce el sonido
    private void OnTriggerEnter(Collider weaponCollider)
    {
        if (weaponCollider.gameObject.CompareTag("Player"))
        {
            (weaponCollider.gameObject.GetComponent("Health") as Health).currentHealth -= attackEnemy;
            AudioManager.Instance.PlaySound(enemyHit);
        }
    }
}
