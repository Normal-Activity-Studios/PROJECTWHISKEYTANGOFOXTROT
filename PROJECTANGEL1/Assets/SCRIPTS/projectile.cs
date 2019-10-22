using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{



    public Rigidbody bullet;
    public Transform barrelend;


    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bullet, barrelend.position, barrelend.rotation) as Rigidbody;
            bulletInstance.AddForce(barrelend.forward * 10000);// 10000 IS MAX FURTHER THAN THAT BREAKS PHYSICS
        }

    }
}
