using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsUI : MonoBehaviour
{
    public Image[] hearts;
    private int heartsVisible;
    private static HeartsUI instance;

    void Start()
    {
        instance = this;
        heartsVisible = hearts.Length;
    }

    public static void RemoveHeart()
    {
        instance._RemoveHeart();
    }

    private void _RemoveHeart()
    {
        heartsVisible--;
        if(heartsVisible >= 0)
        {
            hearts[heartsVisible].enabled = false;
        }
    }

    public static void AddHeart()
    {
        instance._AddHeart();
    }

    private void _AddHeart()
    {
        if (heartsVisible >= 0 && heartsVisible != hearts.Length)
        {
            hearts[heartsVisible].enabled = true;
            heartsVisible++;
            PlayerStateMachine._hearts += 1;
        }
    }
}
