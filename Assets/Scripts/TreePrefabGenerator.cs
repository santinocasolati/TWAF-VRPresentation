using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePrefabGenerator : MonoBehaviour
{
    public GameObject treePrefab;
    public int treeAmount;
    public Vector2 size;

    void Start()
    {
        for (int i = 0; i < treeAmount; i++)
        {
            GameObject tree = Instantiate(treePrefab, transform);

            Vector3 rotation = new Vector3();
            rotation.y = Random.Range(0f, 360f);
            tree.transform.rotation = Quaternion.Euler(rotation);

            Vector3 position = new Vector3();
            position.x = Random.Range(0f, size.x);
            position.z = Random.Range(0f, size.y);
            tree.transform.position = position;
        }
    }
}
