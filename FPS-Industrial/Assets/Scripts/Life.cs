using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    //Colision
    private Collider lifeCollision;

    //Audio al colisionar
    //public Sound bullet;

    //Referencia al arma
    public GameObject lifePlayer;

    //Referencia al script del arma
    private Weapon lifeScript;

    void Start()
    {
        lifeCollision = GetComponent<Collider>();
    }

    /*Comprobar si ha colisionado con el jugador
     * Reproducir audio de recarga
     * añadir 5 de munición al arma
     * desactivar el item
    */
    private void OnTriggerEnter(Collider lifeCollision)
    {
        if (lifeCollision.CompareTag("Player"))
        {
            //AudioManager.Instance.PlaySound(bullet);
            (lifeCollision.gameObject.GetComponent("Health") as Health).currentHealth += 5;
            this.gameObject.SetActive(false);
        }
    }
}
