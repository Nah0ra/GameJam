using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject CinematicCutscene;

    private GameObject PlayerCam;

    private GameObject Gun;

    private GameObject GunHolster;

    GameData gamedata;

    private void Start() 
    {
        gamedata = GameObject.Find("Scripts").GetComponent<GameData>();
        Gun = GameObject.Find("Pistol");
        GunHolster = GameObject.Find("GunHolster");
        CinematicCutscene = GameObject.Find("CinematicCutscene");
        PlayerCam = GameObject.Find("Main Camera");
        PlayerCam.SetActive(false);
        StartCoroutine(SwitchCam());

    }

    public void ReturnToHolster()
    {
        Gun.transform.position = GunHolster.transform.position;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "Scrap")
        {
            gamedata.Scrap++;
            Destroy(other.gameObject);
        }
    }

    public void Teleport()
    {
           if (gamedata.CoreHealth >= 75 && gamedata.CoreHealth <= 100)
           {
            gameObject.transform.position = new Vector3(60,-62.8499985f,1.52999997f);
            StartCoroutine(ReturnHome());
           }
           else if (gamedata.CoreHealth >=50 && gamedata.CoreHealth <=74)
           {
            gameObject.transform.position = new Vector3(64.42f, -44.5f, 0);
            StartCoroutine(ReturnHome());
           }
           else if (gamedata.CoreHealth >=1 && gamedata.CoreHealth <=49)
           {
            gameObject.transform.position = new Vector3(64.42f, -14.5f, 0);
            StartCoroutine(ReturnHome());
           }


    }


    IEnumerator ReturnHome()
    {
        yield return new WaitForSeconds(30);
        gameObject.transform.position = new Vector3(0, 0, 0);
    }


    IEnumerator SwitchCam()
    {
        yield return new WaitForSeconds(28);
        CinematicCutscene.SetActive(false);
        PlayerCam.SetActive(true);
    }
}
