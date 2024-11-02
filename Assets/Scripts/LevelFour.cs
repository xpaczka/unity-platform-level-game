using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFour : Gameplay {
    public int winningChestIndex;

    void Awake () {
        GameObject[] allChests = GameObject.FindGameObjectsWithTag("all-chests");
        winningChestIndex = Random.Range(0, allChests.Length);
    }

    void Update () {
        if (isChestCollected) {
            Debug.Log("You win");
            Application.Quit();
        }
    }
}
