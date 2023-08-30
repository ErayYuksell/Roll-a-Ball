using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ball;
    Vector3 distance;
    void Start()
    {
        distance = transform.position - ball.transform.position;  //Cameranin topu surekli takip etmesi icin camera posizyonundan top poz cikardik 
        // daha sonra update icinde camera poz surekli top poz ve aradaki sabit farki ekliyoruz top pozisyonu degisdikce aradaki sabit farki ekleyerek takip eder 
    }

    
    void LateUpdate() //camera islemlerinde genelde bu kullanilir goruntu daha iyi oluyormus daha  tum update ler bittikten sonra calisir 
    {
        transform.position = ball.transform.position + distance;
    }
}
