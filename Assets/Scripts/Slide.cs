using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    private Vector2 start;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            start = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector2 con = Input.mousePosition;
            Swipe(con);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 1.5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 1.5f);
        }
    }

    void Swipe(Vector3 final)
        {
            float disX = Mathf.Abs(start.x - final.x);
            float disY = Mathf.Abs(start.y - final.y);
            if (disX > 0 || disY > 0)
            {
                if (disX > disY)
                {
                    if (start.x > final.x)
                    {
                        if (gameObject.transform.localPosition.x >= -4.8)
                        {
                            transform.Translate(Vector3.left * Time.deltaTime * 1.5f);
                        }
                    }
                    else
                    {
                        if (gameObject.transform.localPosition.x <= 4.8)
                        {
                            transform.Translate(Vector3.right * Time.deltaTime * 1.5f);
                        }
                    }
                }
            }
        }

    }