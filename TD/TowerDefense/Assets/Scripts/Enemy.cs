using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health;
    public float MaxHealth;

    public int DamageDealt;
    public int GoldWorth;

    public GameObject HealthBar;

    private HealthBar myHpBar;
    public void InitializeUnit(){
        Health = MaxHealth;
        myHpBar = HealthBar.GetComponent<HealthBar>();
        myHpBar.SetMaxHp((int)Health);
        UpdateHpBarOrientation();
        

    }

    //use to take damage from towers
    public void TakeDamage(int damageDealt){
        //deal damage to yourself
        Health -= damageDealt;
        myHpBar.SetHealth((int)Health);
        if(Health <= 0){
            KillUnit();
        }

    }

    
    //deal damage to player hp

    public void DealDamageToPlayer(){
        PlayerManager.instance.AddLife(-1* DamageDealt);
        KillUnit();
    }

    public void KillUnit(){
        //play death animation
        //wait 1s for death animation to complete
        //kill unit
        PlayerManager.instance.AddEnemyKilled();
        Destroy(gameObject);
        
    }
//keeps hp bar oriented even if unit rotates
public void UpdateHpBarOrientation(){
     Quaternion myCurrentTransform = transform.rotation;
     float myRot = myCurrentTransform.y;
     float output = myRot + ((180 -0 ) / (1)) * (myRot - 0);
     HealthBar.transform.Rotate(0f,output,0f,Space.Self);

}

    void Update(){
        if(Input.GetKeyDown("space")){
            TakeDamage(1);
        }
    }



    
}
