using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Source: https://www.youtube.com/watch?v=GoHYSOFiZHc&list=PLujKcy4gXDJXOAvJQgJlCIn3BnZk7wyZp 2:35
//monobehaviour extension is deleted, this means you cant attach this script to a game object. But you can refer to it inside of a Monobehaviour script for the player

[System.Serializable] //this will allow custom class to be readable by Unity
public class Stats
{
    public int atk;
    public int def;
    public int piercing;
    public int hp;

    public int skill1;
    public int skill2;
    public int skill3;
    public int skill4;
    public int skill5;
    public int skill6;

}
