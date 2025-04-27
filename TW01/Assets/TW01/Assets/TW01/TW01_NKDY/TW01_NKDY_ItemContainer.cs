using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW01_NKDY_ItemContainer : MonoBehaviour
{
    public GameObject Item;

    void Start()
    {
        int cloneCount = 15;
        for(int i = 0; i < cloneCount  ; i++) {
            Clone_Items(i);   
        }
    }

    void Clone_Items(int id){
        Vector3 randomSphere = Random.insideUnitSphere*2.5f;
        randomSphere.y = 0f;
        Vector3 randomPos = randomSphere + transform.position;

        float randomAngle = Random.value * 360;
        Quaternion randomRot = Quaternion.Euler(0,randomAngle, 0);
        GameObject Clone  = Instantiate(Item, randomPos, randomRot);
        Clone.transform.SetParent(transform);
        Clone.name = "Clone-" + string.Format("${0:D4}", id);
    }
}
