using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    //referring to the Stats script, now Player script has the variables in that script too.
    //public Stats charStats;


    //stats
    int atk;
    int def;
    int piercing;
    int hp;
    public TextMeshProUGUI atktext;
    public TextMeshProUGUI deftext;
    public TextMeshProUGUI piercingtext;
    public TextMeshProUGUI hptext;

    int skill1;
    int skill2;
    int skill3;
    int skill4;
    int skill5;
    int skill6;

    public TextMeshProUGUI skill1text;
    public TextMeshProUGUI skill2text;
    public TextMeshProUGUI skill3text;
    public TextMeshProUGUI skill4text;
    public TextMeshProUGUI skill5text;
    public TextMeshProUGUI skill6text;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RandomizeStats(); 
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RandomizeUpgrades();
        }
    }

    //method to randomize the stats
    public void RandomizeStats()
    {
        atk = Random.Range(5000, 10000);
        def = Random.Range(3000, 5000);
        piercing = Random.Range(70, 98);
        hp = Random.Range(4000, 8000);

        atktext.text = atk.ToString();
        deftext.text = def.ToString();
        piercingtext.text = piercing.ToString();
        hptext.text = hp.ToString();
    }

    public void RandomizeUpgrades()
    {
        skill1 = Random.Range(10, 60);
        skill2 = Random.Range(10, 60);
        skill3 = Random.Range(10, 60);
        skill4 = Random.Range(10, 60);
        skill5 = Random.Range(10, 60);
        skill6 = Random.Range(10, 60);

        skill1text.text = "+" + skill1.ToString();
        skill2text.text = "+" + skill2.ToString();
        skill3text.text = "+" + skill3.ToString();
        skill4text.text = "+" + skill4.ToString();
        skill5text.text = "+" + skill5.ToString();
        skill6text.text = "+" + skill6.ToString();
    }

}
