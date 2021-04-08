using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnBullet : MonoBehaviour
{

    //Gameobject del item de balas
    public GameObject[] itemBullet;

    // Start is called before the first frame update
    void Start()
    {
        SpawnItem();
    }

    public void SpawnItem()
    {
        Instantiate(itemBullet[Random.Range(0, itemBullet.Length)], transform.position, Quaternion.identity);
    }
}
