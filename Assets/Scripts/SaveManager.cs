using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //input output lib
using System.Runtime.Serialization.Formatters.Binary; 

public class SaveManager : MonoBehaviour
{
    private Player _player;

    void Awake()
    {
        _player = GameObject.FindObjectOfType<Player>();    
    }

    public void Start()
    {
        //create file or open a file to save the data to (filestream). In Unity we have PersistentDataPath
        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.OpenOrCreate); //standard .dat data but can use anything

        //Binary formatter, to write data to a file
        BinaryFormatter formatter = new BinaryFormatter();

        //Serialization method to write to the file
        formatter.Serialize(file, _player.charStats);

        file.Close(); //so the file will not be opened throughout the game
    }

    public void Load()
    {

    }
}
