using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //Daño de ataque
    public int fireAttack = 5;

    // Colisión de la bala
    private Collider bulletCollider;

    // Sonido de ataque
    public Sound bulletHit;

    // Start is called before the first frame update
    void Start()
    {
        bulletCollider = GetComponent<Collider>();
    }

    //Si el arma colisiona con el jugador, le resta vida y se reproduce el sonido
    private void OnTriggerEnter(Collider weaponCollider)
    {
        if (weaponCollider.gameObject.CompareTag("Player"))
        {
            (weaponCollider.gameObject.GetComponent("Health") as Health).currentHealth -= fireAttack;
            AudioManager.Instance.PlaySound(bulletHit);
        }
    }
}
