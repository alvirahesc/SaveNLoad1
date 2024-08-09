using UnityEngine;
using TMPro;
//i deleted some namepsace cuz they not being used

public class Player : MonoBehaviour
{
    //I say we do it like this its about saving ok?!
    public AudioClip[] clip;
    public AudioSource audioSource;

    //stats
    int atk;
    int def;
    int piercing;
    int hp;
    public TextMeshProUGUI atktext;
    public TextMeshProUGUI deftext;
    public TextMeshProUGUI piercingtext;
    public TextMeshProUGUI hptext;

    //skills
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

    //method to randomize the stats and play sound
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

        audioSource.clip = clip[0];
        audioSource.Play();
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

        audioSource.clip = clip[0];
        audioSource.Play();
    }

}
