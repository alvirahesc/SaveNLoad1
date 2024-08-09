using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //input output lib
using System.Runtime.Serialization.Formatters.Binary; //to use the binary formatter
using System.Runtime.Serialization; //to show the serialization errors

public class SaveManager : MonoBehaviour
{
    private Player _player;

    void Awake()
    {
        _player = GameObject.FindObjectOfType<Player>();    
    }

    public void Save()
    {
        //create file or open a file to save the data to (filestream). In Unity we have PersistentDataPath
        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.OpenOrCreate); //standard .dat data but can use anything

        //Debug.Log("Saved Successfully!");

        try
        {
            //Binary formatter, to write data to a file
            BinaryFormatter formatter = new BinaryFormatter();
            //this is poor practice as this doesnt let you save Unity native data types such as quaternion,position, etc, can be solved using Struct
            //Serialization method to write to the file
            formatter.Serialize(file, _player.charStats);
        }
        catch(SerializationException e)
        {
            Debug.LogError("Issue when serializing this data: " + e.Message);
        }
        finally { file.Close(); } //dont forget to close it!
    }

    public void Load()
    {
        //Doing the opposite of save here!
        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.Open);

        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            //this is poor practice as this doesnt tell you if there is any error when deserializing the file, use try-catch-finally. (i did yay)
            //Deserialize the data, and then set cast it as stats since Deserialize returns a gameObject
            _player.charStats = (Stats)formatter.Deserialize(file); //you can do it like this
            //_player.charStats = formatter.Deserialize(file) as Stats; //or like this
        }
        catch (SerializationException e)
        {
            Debug.LogError("Error Deserializing Data " + e.Message);
        }
        finally { file.Close(); } //dont forget to close it!

        //this can be improved omg
        _player.atktext.text = _player.charStats.atk.ToString();
        _player.deftext.text = _player.charStats.def.ToString();
        _player.piercingtext.text = _player.charStats.piercing.ToString();
        _player.hptext.text = _player.charStats.hp.ToString();

        _player.skill1text.text = "+" + _player.charStats.skill1.ToString();
        _player.skill2text.text = "+" + _player.charStats.skill2.ToString();
        _player.skill3text.text = "+" + _player.charStats.skill3.ToString();
        _player.skill4text.text = "+" + _player.charStats.skill4.ToString();
        _player.skill5text.text = "+" + _player.charStats.skill5.ToString();
        _player.skill6text.text = "+" + _player.charStats.skill6.ToString();

    }
}
