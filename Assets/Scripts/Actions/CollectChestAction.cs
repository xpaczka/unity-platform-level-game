using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectChestAction : RaycastAction {
    [SerializeField]
    Gameplay gameplayScript;

    protected override void Initialize() {
        thresholdDistance = 4;
    }

    protected override void OnTargetHit() {
        gameplayScript.isChestCollected = true;
    }

    void Update() {
        if (!gameplayScript.isChestCollected && Input.GetKeyDown(KeyCode.R)) {
            PerformRaycastAction();
        }
    }
}
