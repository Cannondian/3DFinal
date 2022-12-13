using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    public int popUpIndex;

    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[popUpIndex].SetActive(true);
            }
            else
            {
                popUps[popUpIndex].SetActive(false);
            }
        }

        if (popUpIndex == 0)
        {
            Debug.Log("Showing Mouse Image");
            if((Input.GetAxis("Mouse X") != 0) || (Input.GetAxis("Mouse Y") != 0))
            {

                Debug.Log("Mouse Moved Sense");
                popUpIndex++;
            }
            else if (popUpIndex == 1)
            {
                if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
                {
                    popUpIndex++;
                }
            }
            else
            {
                popUpIndex = 2;
            }
        }
    }
}
