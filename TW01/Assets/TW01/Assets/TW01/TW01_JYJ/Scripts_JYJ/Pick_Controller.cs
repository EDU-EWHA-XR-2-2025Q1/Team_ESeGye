using UnityEngine;

public class Pick_Controller : MonoBehaviour
{
    int clickCounter = 0;

    public void Add_Click(GameObject clickedApple)
    {
        clickCounter++;
        Debug.Log($"{clickCounter} �� Ŭ����!");
        Destroy(clickedApple); // ��� ����
    }
}
