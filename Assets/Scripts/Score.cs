using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int useforce = 0;
    public static int balls1 = 0;
    public static int balls2 = 0;
    public static int balls3 = 0;
    public static int level = 1;
    public Text nballs1;
    public Text nballs2;
    public Text nballs3;
    public Text levelText;

    void Update()
    {
        if (levelText)
        {
            if(level >=10)
            {
                levelText.text = level + "           " + (level + 1);
            }
            else
            {
                levelText.text = level + "               " + (level + 1);
            }
        }
        nballs1.text = balls1 + "/20";
        nballs2.text = balls2 + "/30";
        nballs3.text = balls3 + "/40";
    }
}