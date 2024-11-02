using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFour : Gameplay {
    public GameObject[] allChests;
    public int winningChestIndex;

    void Awake () {
        allChests = GameObject.FindGameObjectsWithTag("all-chests");
        winningChestIndex = Random.Range(0, allChests.Length);
    }

    void Update () {
        if (isChestCollected) {
            Debug.Log("You win");
            Application.Quit();
        }
    }
}
