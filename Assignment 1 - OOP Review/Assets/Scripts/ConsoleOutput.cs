/*
 * Jacob Zydorowicz
 * ConsoleOutpout.cs
 * Assignment 1 - OOP Review
 * Main script to demonstrate OOP concepts
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleOutput : MonoBehaviour
{
    public List<Enemies> mobs = new List<Enemies>();
    public List<Walk> walkables = new List<Walk>();
    // Start is called before the first frame update
    void Start()
    {
        Radscorpion smallScorp = new Radscorpion();
        Gecko fireGecko = new Gecko();

        smallScorp.setSize("small");
        smallScorp.setDamage(20);
        smallScorp.setHealth(20);
        Debug.Log("The " +smallScorp.getSize()+" radscorpion does " + smallScorp.getDamage() + " damage.");
        Debug.Log("The " + smallScorp.getSize() + " radscorpion has " + smallScorp.getHealth() + " health.");
        smallScorp.walk();
        smallScorp.sting(smallScorp.getDamage());

        fireGecko.setSpecies("Fire");
        fireGecko.setDamage(60);
        fireGecko.setHealth(165);
        Debug.Log("The "+fireGecko.getSpecies()+"gecko does " + fireGecko.getDamage() + " damage.");
        Debug.Log("The " + fireGecko.getSpecies()+ "gecko has "+ fireGecko.getHealth() + " health.");
        fireGecko.walk();
        fireGecko.jump();


        Enemies largeScorp = new Radscorpion();
        largeScorp.setHealth(130);
        Enemies medScorp = new Radscorpion();
        medScorp.setHealth(20);
        Enemies greenGecko = new Gecko();
        greenGecko.setHealth(225);
        Enemies goldenGecko = new Gecko();
        goldenGecko.setHealth(125);
        Enemies human = new Human();
        human.setHealth(80);

        mobs.Add(largeScorp);
        mobs.Add(medScorp);
        mobs.Add(greenGecko);
        mobs.Add(goldenGecko);
        mobs.Add(human);

        Walk scorp1 = new Radscorpion();
        Walk scorp2 = new Radscorpion();
        Walk gecko1 = new Gecko();
        Walk gecko2 = new Gecko();
        Walk human1 = new Human();

        walkables.Add(scorp1);
        walkables.Add(scorp2);
        walkables.Add(gecko1);
        walkables.Add(gecko2);
        walkables.Add(human1);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach(Enemies enemies in mobs)
            {
                Debug.Log("Health of enemy equals:" + enemies.getHealth());
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (Walk enemies in walkables)
            {
                enemies.walk();
            }
        }
    }
}
