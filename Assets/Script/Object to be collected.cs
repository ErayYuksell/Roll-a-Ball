using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecttobecollected : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
       
        transform.Rotate(new Vector3(15f, 20f, 35f) * Time.deltaTime * 5f);
        
    }
}
