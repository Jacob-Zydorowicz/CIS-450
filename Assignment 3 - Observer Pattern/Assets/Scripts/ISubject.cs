/*
 * Jacob Zydorowicz
 * ISubject.cs
 * Assignment 3 - Observer Pattern
 * ISubject interface to demonstrate observer pattern 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }


