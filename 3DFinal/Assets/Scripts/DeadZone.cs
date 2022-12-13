using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    public PlayerStateMachine player;
    public AudioClip deadSound;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerStateMachine>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            player.playerSounds.PlayOneShot(deadSound);
            PlayerStateMachine._hearts = 4;
            PlayerStateMachine._coins = 0;
            PlayerStateMachine._starPieces = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
