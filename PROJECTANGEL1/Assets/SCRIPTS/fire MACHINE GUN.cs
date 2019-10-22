using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireMACHINEGUN : MonoBehaviour
{



    public Rigidbody projectile;
    public Transform barrelend;



    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectile, barrelend.position, barrelend.rotation);
        
        }



    }
}
