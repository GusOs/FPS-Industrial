using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnLife : MonoBehaviour
{

    //Gameobject del item de vida
    public GameObject[] itemLife;

    // Start is called before the first frame update
    void Start()
    {
        SpawnItem(); 
    }

    public void SpawnItem()
    {
        Instantiate(itemLife[Random.Range(0, itemLife.Length)], transform.position, Quaternion.identity);

        itemLife = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject go in itemLife)
        {
            go.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
