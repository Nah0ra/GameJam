using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameData : MonoBehaviour
{
    public int BuildHealth;
    public int CoreHealth;
    public int Scrap;
    public int PlayerHealth;

    public TextMeshProUGUI ScrapText;

    public Slider BuildSlide;
    public Slider CoreSlide;
    public Slider PlayerSlide;

    public GameObject LaserTurret;

    public GameObject Trap1;
    public GameObject Trap2;

    public GameObject Barricades;

    public GameObject Dome;

    public bool GotBarricades;

    public bool GotLasers;

    public bool GotTraps;

    public bool GotShields;

    

    private void Start() 
    {
        BuildSlide = GameObject.Find("BuildBar").GetComponent<Slider>();
        CoreSlide = GameObject.Find("EnemyBar").GetComponent<Slider>();
        PlayerSlide = GameObject.Find("HealthBar").GetComponent<Slider>();
        ScrapText = GameObject.Find("ScrapText").GetComponent<TextMeshProUGUI>();
        LaserTurret = GameObject.Find("Laser");
        Dome = GameObject.Find("Dome");
        Barricades = GameObject.Find("Barricades");
        LaserTurret.SetActive(false);
        Dome.SetActive(false); 
        
        Trap1 = GameObject.Find("Trap");
        Trap2 = GameObject.Find("Trap 2");

        Trap1.SetActive(false);
        Trap2.SetActive(false);

        Barricades.SetActive(false);
        
        
        

        BuildHealth = 50;
        BuildSlide.value = 50;

        CoreHealth = 100;
        CoreSlide.value = 100;

        PlayerHealth = 20;
        PlayerSlide.value = 20;

        ScrapText.text = "0";

    }

    private void Update() 
    {
        BuildSlide.value = BuildHealth;
        CoreSlide.value = CoreHealth;
        PlayerSlide.value = PlayerHealth;
        ScrapText.text = "" + Scrap;

        if (PlayerHealth == 0)
        {
            SceneManager.LoadScene("LobbyScene");
        }

        if (GotLasers)
        {
            LaserTurret.SetActive(true);
        }

        if (GotTraps)
        {
            Trap1.SetActive(true);
            Trap2.SetActive(true);
        }

        if(GotBarricades)
        {
            Barricades.SetActive(true);
        }

        if (GotShields)
        {
            Dome.SetActive(true);
        }

        if (CoreHealth <= 0)
        {
            SceneManager.LoadScene("LobbyScene");
        }

        if (PlayerHealth <= 0)
        {
            SceneManager.LoadScene("LobbyScene");
        }



    }
}
