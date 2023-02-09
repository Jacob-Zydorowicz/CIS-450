/*
 * Jacob Zydorowicz
 * IObserver.cs
 * Assignment 3 - Observer Pattern
 * IObserver interface to demonstrate observer pattern 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IObserver
    {
        void UpdatePlayerData(knownColors playerColor, height playerScale );

    }


