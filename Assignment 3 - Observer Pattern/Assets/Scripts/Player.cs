/*
 * Jacob Zydorowicz
 * PlayerData.cs
 * Assignment 3 - Observer Pattern
 * Player class that takes communicated player data using observer patter 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IObserver
{
    private knownColors currentColor;
    private height currentHeight;

    public PlayerData playerData;
    public void UpdatePlayerData(knownColors playerColor, height playerScale)
    {
        this.currentHeight = playerScale;
        showHeight(); 
        this.currentColor = playerColor;
        showColor();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerData.RegisterObserver(this);
    }

    //changes color based on player data
    public void showColor()
    {
        switch (currentColor)
        {
            case knownColors.WHITE:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                break;
            case knownColors.BLACK:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
            case knownColors.RED:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case knownColors.BLUE:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case knownColors.GREEN:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case knownColors.YELLOW:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
        }
    }

    //changes height based on player data
    public void showHeight()
    {
        gameObject.transform.position = new Vector3(0, 5, 0);
        switch (currentHeight)
        {
            case height.MEDIUM:
                gameObject.transform.localScale = new Vector3(1, 2, 1);
                break;
            case height.TALL:
                gameObject.transform.localScale = new Vector3(1, 4, 1);
                break;
            case height.SHORT:
                gameObject.transform.localScale = new Vector3(1, 1, 1);
                break;

        }
    }
}
