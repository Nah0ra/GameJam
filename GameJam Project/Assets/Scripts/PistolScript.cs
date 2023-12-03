using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PistolScript : MonoBehaviour
{

    [SerializeField]
    private Animator FireAnim;

    private GameObject muzzle;

    public void Start()
    {
        FireAnim = GetComponent<Animator>();
        muzzle = transform.GetChild(5).gameObject;
    }

    public void FireGun()
    {
        FireAnim.Play("Fire");
        RaycastHit hit;
        if (Physics.Raycast(muzzle.transform.position, muzzle.transform.forward, out hit))
        {
            if(hit.transform.tag == "Enemy")
            {
                hit.transform.gameObject.GetComponent<Enemy>().TakeDamage();
            }
            else
            {
                return;
            }
        }
        
    }

   
}
