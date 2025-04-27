using UnityEngine;

public class Basket_Controller : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Item"))
        {
            Debug.Log("바구니에 사과 들어감!");
            Destroy(other.gameObject);
        }
    }
}
