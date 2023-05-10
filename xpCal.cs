using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xpCal : MonoBehaviour
{
    public int givenXP = 200;
    public float xpRequiredMultiplier = 1.5f; // The factor by which the XP requirement increases per level
    public int startingXP = 1000; // The amount of XP required for the first level
    int currentLevel = 1; // The current level based on the given XP

    public int CalculateLevel(int xp)
    {
        int xpRequired = startingXP;
        while (xp >= xpRequired)
        {
            xpRequired = Mathf.RoundToInt(startingXP * Mathf.Pow(xpRequiredMultiplier, currentLevel ));
            currentLevel++;
        }
       // currentLevel--; // Adjust the current level based on the XP range
        return currentLevel;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(CalculateLevel(givenXP));
        }
    }
}
