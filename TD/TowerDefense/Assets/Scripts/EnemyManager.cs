using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
   public static EnemyManager instance = null;
    public int totalEnemyWaves;

    public int CurrentWave = 0;
  
  [Header("Containers")]
    public List<GameObject> allEnemies = new List<GameObject>();

    public GameObject[] EnemyWaves;
    public GameObject targetDestination;



    public GameObject enemySpawnLocation;

    //make it a singleton
    void Awake(){
        if(instance == null){
           instance = this;
        }
        else if(instance!= this){
            Destroy(gameObject);
        }
        totalEnemyWaves = EnemyWaves.Length;
    }

    public void AddEnemyToManager(GameObject newEnemy){
        allEnemies.Add(newEnemy);
    }

    public void SpawnNextWave(){
        if(CurrentWave < totalEnemyWaves){
            EnemyWave currentWave = EnemyWaves[CurrentWave].GetComponent<EnemyWave>();
            StartCoroutine(currentWave.SpawnWave(targetDestination));
            Debug.Log("Spawning wave: " + CurrentWave);
        }
        else{
            Debug.Log("wave limit reached");
        }
        CurrentWave ++;

    }


}
