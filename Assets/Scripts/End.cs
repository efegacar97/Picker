using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public GameObject nextLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "1")
        {
            Score.level++;
            Score.balls1 = 0;
            Score.balls2 = 0;
            Score.balls3 = 0;
            Score.useforce = 0;
            nextLevel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}