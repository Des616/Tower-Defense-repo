using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Enemies;
    public float TimeToStartSpawning;
    public float TimeBetweenSpawns = 0.0f;

    public IEnumerator SpawnWave(){
        
        float offSet = 0.0f;
        foreach(GameObject enemy in Enemies){
            GameObject newEnemy = Instantiate(enemy,EnemyManager.instance.transform);
            newEnemy.GetComponent<Enemy>().InitializeUnit();

            offSet += -10.0f;
            Vector3 newPos = newEnemy.transform.position;
            newPos.x += offSet;
            newEnemy.transform.position = newPos;
            
    
            
            
            EnemyManager.instance.AddEnemyToManager(newEnemy);
             yield return new WaitForSeconds(TimeBetweenSpawns);

        }
    }

//wait a certain amount of time between spawning each enemy
    private IEnumerator TTW(float timeToWait){
        yield return new WaitForSeconds(timeToWait);
        
        
    }
}
