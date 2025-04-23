using UnityEngine;

public class Item_Controller : MonoBehaviour
{
    private bool isPicked = false;

    void OnMouseDown()
    {
        if (isPicked) return;

        isPicked = true;

        Debug.Log("Pick!");

        Rigidbody rb = GetComponent<Rigidbody>();

        rb.useGravity = false;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.isKinematic = true; 

        Transform cam = Camera.main.transform;
        Vector3 holdPosition = cam.position + cam.forward * 1.5f + Vector3.down * 0.2f;

        transform.position = holdPosition;
        transform.rotation = cam.rotation;

        transform.SetParent(cam);

    }

}
