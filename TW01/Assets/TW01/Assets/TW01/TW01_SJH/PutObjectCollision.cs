using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutObjectCollision : MonoBehaviour
{
    public GameObject UI;

    private void OnTriggerEnter(Collider other)
    {
        print("충돌했다! " + other.name);  

        if (other.CompareTag("Basket"))
        {
            UI.GetComponent<TW01_SJH_UI_Controller>().Increase_PutCounts();
        }
    }
}
