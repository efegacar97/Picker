using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public int ballnumber = 0;
    public bool check = false;
    private bool iscounted = false;
    private float thrust = 4.0f;
    Rigidbody rb;
    bool pushOnce = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Basket" && !iscounted)
        {
            Score.balls1++;
            iscounted = true;
            Destroy(gameObject,6);
        }
        if (collision.transform.name == "Basket 2" && !iscounted)
        {
            Score.balls2++;
            iscounted = true;
            Destroy(gameObject, 6);
        }
        if (collision.transform.name == "Basket 3" && !iscounted)
        {
            Score.balls3++;
            iscounted = true;
            Destroy(gameObject, 6);
        }

        if (collision.transform.name == "Platform")
        {
            ballnumber = 1;
        }
        if (collision.transform.name == "Platform 2")
        {
            ballnumber = 2;
        }
        if (collision.transform.name == "Platform 3")
        {
            ballnumber = 3;
        }
        if (collision.transform.name == "1" || collision.transform.name == "2")
        {
            rb.AddForce(transform.forward * -2, ForceMode.Impulse);
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.transform.name == "Check")
        {
            transform.Translate(Vector3.back * Time.deltaTime * 0.5f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Check")
        {
            check = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Check")
        {
           check = false;
           rb.AddForce(transform.forward * -2, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
       if(Score.useforce == 1 && pushOnce && check && ballnumber==1)
        {
            rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
            pushOnce = false;
        }
        if (Score.useforce == 2 && pushOnce && check && ballnumber==2)
        {
            rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
            pushOnce = false;
        }
        if (Score.useforce == 3 && pushOnce && check && ballnumber==3)
        {
            rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
            pushOnce = false;
        }
    }
}