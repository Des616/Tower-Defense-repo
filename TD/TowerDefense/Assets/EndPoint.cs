using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
       
         if(collision.gameObject.tag =="EnemyUnit"){
             GameObject temp = collision.gameObject;
             temp.GetComponent<Enemy>().DealDamageToPlayer();
             temp.GetComponent<Enemy>().KillUnit();
         }

    }
}
