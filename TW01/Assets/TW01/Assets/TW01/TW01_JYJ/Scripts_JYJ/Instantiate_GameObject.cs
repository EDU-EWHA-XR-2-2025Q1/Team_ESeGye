using UnityEngine;

public class Instantiate_GameObject : MonoBehaviour
{
    public GameObject Target;
    public int cloneCount = 10;

    void Start()
    {
        InstantiateObjects(); 
    }

    void InstantiateObjects() 
    {
        for (int i = 0; i < cloneCount; i++)
        {
            Vector3 randomSphere = Random.insideUnitSphere * 5f;
            randomSphere.y = 0f;
            Quaternion randomRot = Quaternion.Euler(0, Random.value * 360f, 0);
            GameObject clone = Instantiate(Target, randomSphere, randomRot);
            clone.SetActive(true);
            clone.name = "Clone-" + string.Format("{0:D4}", i);
            clone.transform.SetParent(transform);
        }
    }
}
