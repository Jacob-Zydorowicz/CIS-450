/*
 * Jacob Zydorowicz
 * PlayerData.cs
 * Assignment 3 - Observer Pattern
 * PlayerData class that communicates player data using observer patter 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum knownColors { WHITE, BLACK, RED, BLUE, GREEN, YELLOW }
public enum height {TALL, MEDIUM, SHORT}
public class PlayerData : MonoBehaviour, ISubject
{
   
    private List<IObserver> obsList = new List<IObserver>();

    private knownColors playerColor = knownColors.WHITE;
    private height playerScale = height.MEDIUM;
    public void NotifyObservers()
    {
        foreach (IObserver observer in obsList)
        {
            observer.UpdatePlayerData(playerColor, playerScale);
            Debug.Log("UpdateData was called from Notify Observers");
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        obsList.Add(observer);
        observer.UpdatePlayerData(playerColor, playerScale);
    }

    public void RemoveObserver(IObserver observer)
    {
        if (obsList.Contains(observer))
        {
            obsList.Remove(observer);
        }
    }

    //updates player color data
    public void changColor()
    {
        switch (playerColor)
        {
            case knownColors.WHITE:
                playerColor = knownColors.BLACK;
                break;
            case knownColors.BLACK:
                playerColor = knownColors.RED;
                break;
            case knownColors.RED:
                playerColor = knownColors.BLUE;
                break;
            case knownColors.BLUE:
                playerColor = knownColors.GREEN;
                break;
            case knownColors.GREEN:
                playerColor = knownColors.YELLOW;
                break;
            case knownColors.YELLOW:
                playerColor = knownColors.WHITE;
                break;
        }
        NotifyObservers();
    }

    //updates player height data
    public void changeHeight()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(0, 5, 0);
        switch (playerScale)
        {
            case height.MEDIUM:
                playerScale = height.TALL;
                break;
            case height.TALL:
                playerScale = height.SHORT;
                break;
            case height.SHORT:
                playerScale = height.MEDIUM;
                break;
            
        }
        NotifyObservers();
    }
 

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.W))
        {
            changeHeight();
            Debug.Log("Player height is now: " + playerScale);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            changColor();
            Debug.Log("Player color is now: " + playerColor);
        }
    }
}
