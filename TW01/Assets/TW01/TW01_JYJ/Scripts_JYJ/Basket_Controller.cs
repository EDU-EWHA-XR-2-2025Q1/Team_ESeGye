using UnityEngine;

public class Basket_Controller : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Item"))
        {
            Debug.Log("�ٱ��Ͽ� ��� ��!");
            Destroy(other.gameObject);
        }
    }
}
