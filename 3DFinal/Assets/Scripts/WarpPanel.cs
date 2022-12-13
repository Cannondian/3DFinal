using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpPanel : MonoBehaviour
{
    private GameMaster gm;
    public int requiredStarPieces = 0;
    public Vector3 nextCheckPointPos;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player")
        {
            if (PlayerStateMachine._starPieces >= requiredStarPieces)
            {
                gm.lastCheckPointPos = nextCheckPointPos;
                PlayerStateMachine.BeatLevel();
            }
        }
    }
}