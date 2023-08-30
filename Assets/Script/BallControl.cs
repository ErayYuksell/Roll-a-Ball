using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public float speed;
    Rigidbody force;
    float counter;
    public int finalCounterObject;
    public Text counterText;
    public Text gameDoneText;
    void Start()
    {
        force = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 vec = new Vector3(yatay, 0f, dikey);
        force.AddForce(vec * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            other.gameObject.SetActive(false);
            counter++;
            counterText.text = "Counter =" + counter;
           if (counter == finalCounterObject)
            {
                gameDoneText.text = "Game Done";
            }
        }
    }
}
