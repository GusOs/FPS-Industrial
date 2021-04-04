using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Colision
    private Collider bulletCollision;

    //Audio al colisionar
    //public Sound bullet;

    //Referencia al arma
    public GameObject weaponPlayer;

    //Referencia al script del arma
    private Weapon weaponScript;

    void Start()
    {
        bulletCollision = GetComponent<Collider>();
    }

    /*Comprobar si ha colisionado con el jugador
     * Reproducir audio de recarga
     * añadir 5 de munición al arma
     * desactivar el item
    */
    private void OnTriggerEnter(Collider bulletCollision)
    {
        if (bulletCollision.CompareTag("Player"))
        {
            //AudioManager.Instance.PlaySound(bullet);
            (bulletCollision.gameObject.GetComponent("Weapon") as Weapon).ammoCapacity += 5;
            this.gameObject.SetActive(false);
        }
    }
}
