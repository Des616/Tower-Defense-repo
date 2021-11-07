using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomBgGenerator : MonoBehaviour
{
   
   public Sprite[] myBackgroundTiles;
   public GameObject tilePrefab;
   public GameObject layoutGroup;
    void Start()
    {
        for(int i = 0;i < 29; i++){
           for(int  k = 0; k < 16; k++){
            GameObject newTile =  Instantiate(tilePrefab,new Vector3(-136 + i * 10,75 - (k*10),0f),Quaternion.identity,layoutGroup.transform);
            newTile.GetComponent<SpriteRenderer>().sprite = myBackgroundTiles[Random.Range(0,myBackgroundTiles.Length)];
           }
        }
    }

    
}
