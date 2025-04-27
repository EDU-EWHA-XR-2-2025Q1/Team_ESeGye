using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW01_PJH_Basket_Controller : MonoBehaviour
{
    public GameObject UI_Controller;

    private void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("Item"))

        {

            Destroy(other.gameObject);

        }

    }
}
