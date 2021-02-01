using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject sphere;
    public GameObject pack9;
    public GameObject pack5;
    public GameObject pack4;
    public GameObject pack6;
    private float y = 8.2f;
    private int[] p = { -12, 38, 94 };

    void Start()
    {
        switch (Score.level)
        {
            case 1:
                vertical(0);
                spiral(1);
                packs8(2);
                break;
            case 2:
                vertical2(0);
                packs3(1);
                packs9(2);
                break;
            case 3:
                packs7(0);
                packs6(1);
                packs3(2);
                break;
            case 4:
                vertical3(0);
                vertical2(1);
                packs6(2);
                break;
            case 5:
                packs1(0);
                packs6(1);
                packs6(2);
                break;
            case 6:
                packs2(0);
                packs7(1);
                packs4(2);
                break;
            case 7:
                packs7(0);
                packs10(1);
                packs7(2);
                break;
            case 8:
                packs5(0);
                vertical3(1);
                spiral(2);
                break;
            case 9:
                spiral2(0);
                vertical2(1);
                packs4(2);
                break;
            case 10:
                vertical3(0);
                spiral2(1);
                packs7(2);
                break;
            default:
                break;
        }
    }

    void vertical(int k)
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(sphere, new Vector3(11.6f, y, i + p[k]), Quaternion.identity);
        }
    }
    void vertical2(int k)
    {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(sphere, new Vector3(10.6f, y, i + p[k]), Quaternion.identity);
            Instantiate(sphere, new Vector3(12.6f, y, i + p[k]+20), Quaternion.identity);
        }
    }
    void vertical3(int k)
    {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(sphere, new Vector3(12.6f, y, i + p[k]), Quaternion.identity);
            Instantiate(sphere, new Vector3(10.6f, y, i + p[k]+22), Quaternion.identity);
        }
    }
    void spiral(int k)
    {
        for (int i = 0; i < 6; i++)
        {
            Instantiate(sphere, new Vector3(11.6f, y, i * 8 + p[k]), Quaternion.identity);
            Instantiate(sphere, new Vector3(11.2f, y, i * 8 + p[k] + 1), Quaternion.identity);
            Instantiate(sphere, new Vector3(10.8f, y, i * 8 + p[k] + 2), Quaternion.identity);
            Instantiate(sphere, new Vector3(11.2f, y, i * 8 + p[k] + 3), Quaternion.identity);
            Instantiate(sphere, new Vector3(11.6f, y, i * 8 + p[k] + 4), Quaternion.identity);
            Instantiate(sphere, new Vector3(12.0f, y, i * 8 + p[k] + 5), Quaternion.identity);
            Instantiate(sphere, new Vector3(12.4f, y, i * 8 + p[k] + 6), Quaternion.identity);
            Instantiate(sphere, new Vector3(12.0f, y, i * 8 + p[k] + 7), Quaternion.identity);
        }
    }
    void spiral2(int k)
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(sphere, new Vector3(11.6f, y, i * 8 + p[k]), Quaternion.identity);
            Instantiate(sphere, new Vector3(11.2f, y, i * 8 + p[k] + 1), Quaternion.identity);
            Instantiate(sphere, new Vector3(10.8f, y, i * 8 + p[k] + 2), Quaternion.identity);
            Instantiate(sphere, new Vector3(11.2f, y, i * 8 + p[k] + 3), Quaternion.identity);
            Instantiate(sphere, new Vector3(11.6f, y, i * 8 + p[k] + 4), Quaternion.identity);
            Instantiate(sphere, new Vector3(12.0f, y, i * 8 + p[k] + 5), Quaternion.identity);
            Instantiate(sphere, new Vector3(12.4f, y, i * 8 + p[k] + 6), Quaternion.identity);
            Instantiate(sphere, new Vector3(12.0f, y, i * 8 + p[k] + 7), Quaternion.identity);
        }
    }
    void packs1(int k)
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(pack5, new Vector3(12.4f, y, i * 8 + p[k]), Quaternion.identity);
            Instantiate(pack4, new Vector3(10.6f, y, i * 8 + p[k] + 4), Quaternion.identity);
        }
    }
    void packs2(int k)
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(pack5, new Vector3(12.4f, y, i * 8 + p[k]), Quaternion.identity);
            Instantiate(pack6, new Vector3(10.6f, y, i * 8 + p[k]+4), Quaternion.identity);
        }
    }
    void packs3(int k)
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(pack4, new Vector3(12.2f, y, i * 8 + p[k]), Quaternion.identity);
            Instantiate(pack9, new Vector3(10.2f, y, i * 8 + p[k]+4), Quaternion.identity);
        }
    }
    void packs4(int k)
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(pack6, new Vector3(12.4f, y, i * 8 + p[k]), Quaternion.identity);
            Instantiate(pack4, new Vector3(10.6f, y, i * 8 + p[k] + 4), Quaternion.identity);
        }
    }
    void packs5(int k)
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(pack5, new Vector3(12.4f, y, i * 12 + p[k]+4), Quaternion.identity);
            Instantiate(pack9, new Vector3(10.6f, y, i * 12 + p[k] + 8), Quaternion.identity);
        }
    }
    void packs6(int k)
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(pack5, new Vector3(12.2f, y, i * 12 + p[k]), Quaternion.identity);
            Instantiate(pack5, new Vector3(11.2f, y, i * 12 + p[k] + 4), Quaternion.identity);
            Instantiate(pack5, new Vector3(10.2f, y, i * 12 + p[k] + 8), Quaternion.identity);
        }
    }
    void packs7(int k)
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(pack4, new Vector3(10.2f, y, i * 12 + p[k]), Quaternion.identity);
            Instantiate(pack4, new Vector3(11.2f, y, i * 12 + p[k] + 4), Quaternion.identity);
            Instantiate(pack4, new Vector3(12.2f, y, i * 12 + p[k] + 8), Quaternion.identity);
        }
    }
    void packs8(int k)
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(pack9, new Vector3(12.2f, y, i * 12 + p[k]), Quaternion.identity);
            Instantiate(pack6, new Vector3(11.2f, y, i * 12 + p[k] + 4), Quaternion.identity);
            Instantiate(pack4, new Vector3(10.2f, y, i * 12 + p[k] + 8), Quaternion.identity);
        }
    }
    void packs9(int k)
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(pack4, new Vector3(12.2f, y, i * 12 + p[k]), Quaternion.identity);
            Instantiate(pack5, new Vector3(11.2f, y, i * 12 + p[k] + 4), Quaternion.identity);
            Instantiate(pack9, new Vector3(10.2f, y, i * 12 + p[k] + 8), Quaternion.identity);
        }
    }
    void packs10(int k)
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(pack5, new Vector3(10.2f, y, i * 12 + p[k]), Quaternion.identity);
            Instantiate(pack4, new Vector3(11.2f, y, i * 12 + p[k] + 4), Quaternion.identity);
            Instantiate(pack6, new Vector3(12.2f, y, i * 12 + p[k] + 8), Quaternion.identity);
        }
    }
}