using UnityEngine;
using TMPro;
//i deleted some namepsace cuz they not being used

public class Player : MonoBehaviour
{
    public Stats charStats;

    //I say we do it like this its about saving ok?!
    public AudioClip[] clip;
    public AudioSource audioSource;

    public TextMeshProUGUI atktext;
    public TextMeshProUGUI deftext;
    public TextMeshProUGUI piercingtext;
    public TextMeshProUGUI hptext;

    //skills
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
        charStats.atk = Random.Range(5000, 10000);
        charStats.def = Random.Range(3000, 5000);
        charStats.piercing = Random.Range(70, 98);
        charStats.hp = Random.Range(4000, 8000);

        atktext.text = charStats.atk.ToString();
        deftext.text = charStats.def.ToString();
        piercingtext.text = charStats.piercing.ToString();
        hptext.text = charStats.hp.ToString();

        audioSource.clip = clip[0];
        audioSource.Play();
    }

    public void RandomizeUpgrades()
    {
        charStats.skill1 = Random.Range(10, 60);
        charStats.skill2 = Random.Range(10, 60);
        charStats.skill3 = Random.Range(10, 60);
        charStats.skill4 = Random.Range(10, 60);
        charStats.skill5 = Random.Range(10, 60);
        charStats.skill6 = Random.Range(10, 60);

        skill1text.text = "+" + charStats.skill1.ToString();
        skill2text.text = "+" + charStats.skill2.ToString();
        skill3text.text = "+" + charStats.skill3.ToString();
        skill4text.text = "+" + charStats.skill4.ToString();
        skill5text.text = "+" + charStats.skill5.ToString();
        skill6text.text = "+" + charStats.skill6.ToString();

        audioSource.clip = clip[0];
        audioSource.Play();
    }

}
