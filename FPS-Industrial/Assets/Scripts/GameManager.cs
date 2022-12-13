using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //Instancia de la propia clase
    public static GameManager Instance;

    //Referencia al objeto de la vida del jugador
    public Health lifeplayer;

    //Referencia al script del jugador
    private FirstPersonCharacter playerScript;

    //Variable para comprobar que el juego está activo
    public bool isGameActive;

    //Objeto spawn del item
    public ItemSpawnLife itemSpawner;


    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        isGameActive = true;
    }

    // Update is called once per frame
    void Start()
    {
        //playerScript = lifeplayer.GetComponent<PlayerMovement>();
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        if (lifeplayer.currentHealth == 0)
        {
            //AudioManager.Instance.PlaySound(gameOverSound);
            isGameActive = false;
            //panelGameOver.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0;
        }
    }

    //Empieza la corrutina del spawn de enemigos
    public void CheckGameState()
    {
        StartCoroutine(SpawnEnemyCoroutine());
    }

    //spawn de enemigos
    public IEnumerator SpawnEnemyCoroutine()
    {
        int wait_time = Random.Range(4, 8);
        yield return new WaitForSeconds(wait_time);
        //enemySpawner.SpawnEnemy();
        //enemySpawner2.SpawnEnemy();
    }
}
