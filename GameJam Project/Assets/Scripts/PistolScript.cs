using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PistolScript : MonoBehaviour
{

    [SerializeField]
    private Animator FireAnim;

    private GameObject muzzle;

    public AudioSource audiosource;

    GameData gameData;
    public void Start()
    {
        FireAnim = GetComponent<Animator>();
        muzzle = transform.GetChild(5).gameObject;
        audiosource = GetComponent<AudioSource>();
        gameData = GameObject.Find("Scripts").GetComponent<GameData>();
    }

    public void FireGun()
    {
        FireAnim.Play("Fire");
        audiosource.Play();
        RaycastHit hit;
        if (Physics.Raycast(muzzle.transform.position, muzzle.transform.forward, out hit))
        {
            if(hit.transform.tag == "Enemy" || hit.transform.tag == "Elite")
            {
                hit.transform.gameObject.GetComponent<Enemy>().TakeDamage();
            }
            else if(hit.transform.tag == "Core")
            {
                gameData.CoreHealth = gameData.CoreHealth - 2;
            }
            else 
            {
                return;
            }
        }
        
    }

   
}
