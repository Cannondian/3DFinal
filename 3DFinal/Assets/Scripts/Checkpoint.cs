using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;
    public MeshRenderer msh_rend;

    // Start is called before the first frame update
    void Start()
    {
        msh_rend = GetComponent<MeshRenderer>();
        msh_rend.enabled = false;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.position;
        }
    }
}
