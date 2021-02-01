using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    private bool ismoving = false;
    private bool check1 = true;
    private bool check2 = true;
    private bool check3 = true;
    public GameObject small1;
    public GameObject small2;
    public GameObject small3;
    public GameObject StartText;
    public GameObject Counter1;
    public GameObject Counter2;
    public GameObject Counter3;
    public GameObject failText;
    public GameObject perfectText;

    void Start()
    {
        Time.timeScale = 2;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!ismoving)
            {
                StartText.SetActive(false);
                StartCoroutine("move");
            }
        }
        if (transform.position.z >= 27)
        {
            if (ismoving && check1)
            {
                Score.useforce++;
                StopCoroutine("move");
                Invoke("startMove", 12);
                check1 = false;
                StartCoroutine("moveSmall1");
                Counter1.SetActive(true);
            }
        }
        if (transform.position.z >= 81)
        {
            if (ismoving && check2)
            {
                Score.useforce++;
                StopCoroutine("move");
                Invoke("startMove", 12);
                check2 = false;
                StartCoroutine("moveSmall2");
                Counter2.SetActive(true);
            }
        }
        if (transform.position.z >= 135)
        {
            if (ismoving && check3)
            {
                Score.useforce++;
                StopCoroutine("move");
                Invoke("startMove", 12);
                check3 = false;
                StartCoroutine("moveSmall3");
                Counter3.SetActive(true);
            }
        }
    }

    private void startMove()
    {
        StartCoroutine("move");
    }
    private void startMoveSmall()
    {
        StartCoroutine("moveSmall");
    }


    IEnumerator move()
    {
        ismoving = true;
            while (true)
            {
               transform.Translate(Vector3.forward * Time.deltaTime * 2.0f);
                yield return null;
            }
    }

    IEnumerator moveSmall1()
    {
        yield return new WaitForSeconds(6);
        Counter1.SetActive(false);
        if (Score.balls1 >= 20)
        {
            GameObject Image1 = GameObject.Find("Image1");
            Image1.GetComponent<Image>().color = new Color32(241, 74, 3, 255);
            perfectText.SetActive(true);
            StartCoroutine("hideText");

            while (true)
            {
                small1.transform.position = Vector3.MoveTowards(small1.transform.position, new Vector3(11.6f, 6.12f, 30.6f), (0.4f) * Time.deltaTime);
                yield return null;
            }
        }
        else
        {
            Time.timeScale = 0;
            failText.SetActive(true);
            
        }
    }

    IEnumerator moveSmall2()
    {
        yield return new WaitForSeconds(6);
        Counter2.SetActive(false);
        if (Score.balls2 >= 30)
        {
            GameObject Image2 = GameObject.Find("Image2");
            Image2.GetComponent<Image>().color = new Color32(241, 74, 3, 255);
            perfectText.SetActive(true);
            StartCoroutine("hideText");

            while (true)
            {
                small2.transform.position = Vector3.MoveTowards(small2.transform.position, new Vector3(11.6f, 6.12f, 84.6f), (0.4f) * Time.deltaTime);
                yield return null;
            }
        }
        else
        {
            Time.timeScale = 0;
            failText.SetActive(true);
        }
    }

    IEnumerator moveSmall3()
    {
        yield return new WaitForSeconds(6);
        Counter3.SetActive(false);
        if (Score.balls3 >= 40)
        {
            GameObject Image3 = GameObject.Find("Image3");
            Image3.GetComponent<Image>().color = new Color32(241,74, 3, 255);
            perfectText.SetActive(true);
            StartCoroutine("hideText");
            
            while (true)
            {
                small3.transform.position = Vector3.MoveTowards(small3.transform.position, new Vector3(11.6f, 6.12f, 138.57f), (0.4f) * Time.deltaTime);
                yield return null;
            }
        }
        else
        {
            Time.timeScale = 0;
            failText.SetActive(true);
        }
    }
    IEnumerator hideText()
    {
        yield return new WaitForSeconds(4.5f);
        perfectText.SetActive(false);
    }
}