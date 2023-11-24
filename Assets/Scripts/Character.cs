using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public string description;
    public int helth;
    public bool active;
    public bool alive;

    public Character(string name,string description)
    {
        this.name=name;
        this.description=description;
        this.helth=1000;
        this.active=false;
        this.alive=true;
    }

    public void printInfo()
    {
        Debug.LogFormat("Персонаж {0}; Здоровье: {1}; Описание: {2}", this.name, this.helth,this.description);
        if(this.alive)
            Debug.Log("Живой");
        else
            Debug.Log("Мертвый");
        Debug.Log("____________________________________________");
    }
}
