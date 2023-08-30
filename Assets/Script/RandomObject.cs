using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
    public GameObject objectPrefab;
    Vector3 position;
    void Start()
    {

        InvokeRepeating("CreateObject", 1f, 2f);

    }

    public void CreateObject()
    {


        Instantiate(objectPrefab, position, Quaternion.identity);
        if (transform.position == position)
        {
            gameObject.SetActive(false);
        }


    }
    void Update()
    {
        position = new Vector3(Random.Range(-9, 9), .4f, Random.Range(-9, 9));
    }
}
