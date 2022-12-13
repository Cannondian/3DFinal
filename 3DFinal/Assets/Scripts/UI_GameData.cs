using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_GameData : MonoBehaviour
{
    public int coins = 0;
    int starPieces = 0;

    public TextMeshProUGUI coinText;
    public TextMeshProUGUI starPieceText;

    // Update is called once per frame
    void Update()
    {
        coins = PlayerStateMachine._coins;
        starPieces = PlayerStateMachine._starPieces;
        coinText.text = coins.ToString();
        starPieceText.text = " " + starPieces.ToString() + "/5";
    }
}
