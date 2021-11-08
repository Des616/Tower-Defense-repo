using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance= null;
    public int Gold = 0;
    public int Lives = 10;

    public int EnemiesKilled = 0;

    //make it a singleton
    void Awake(){
        if(instance == null){
            instance = this;
        }
        else if(instance!= this){
            Destroy(gameObject);
        }
    }


    public void AddGold(int goldToAdd){
        Gold += goldToAdd;
    }

    public void AddLives(int Life){
        Lives += Life;
    }

    public void AddEnemyKilled(){
        EnemiesKilled++;
    }
}
