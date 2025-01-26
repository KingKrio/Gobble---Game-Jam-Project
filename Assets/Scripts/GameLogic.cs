using GoSharpCore;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    private GameInfo gi;
    private Game game;
    private int blackOrWhite;
    public TextMeshProUGUI turnCounter;

    // Start is called before the first frame update
    void Start()
    {
        System.Random startColour = new System.Random();
        blackOrWhite = startColour.Next(2);

        gi = new GameInfo() { Handicap = 2, StartingPlayer = (blackOrWhite  == 0)? Content.Black : Content.White };
        game = new Game(gi);

        //turnCounter = GetComponent<TextMeshProUGUI>();
        if (blackOrWhite == 0)
            turnCounter.text = "Player 1 Turn";
        else
            turnCounter.text = "Plaer 2 Turn";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateGameState(int row, int col)
    {

    }

    public int getCurrentColour()
    {
        return blackOrWhite;
    }
    
    public void changeColour(int colour)
    {
        blackOrWhite = colour;
        if (blackOrWhite == 0)
            turnCounter.text = "Player 1 Turn";
        else 
            turnCounter.text = "Player 2 Turn";
    }
}
