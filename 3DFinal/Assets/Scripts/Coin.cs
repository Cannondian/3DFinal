using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public PlayerStateMachine player;
    public AudioClip collectSound;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerStateMachine>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerStateMachine._coins += 1;
            player.playerSounds.PlayOneShot(collectSound);
            Destroy(gameObject);
        }
    }
}
