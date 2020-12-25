using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pouch : MonoBehaviour
{
    public GameObject coin_group;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    bool coin_protect=false;
    void OnTriggerStay(Collider other) 
    {
        /**
        if(other.CompareTag("Player") && gun.popper && !coin_protect)
        { 
            Instantiate(coin_group,transform.position,Quaternion.identity);
            coin_protect=false;
            Destroy(gameObject,0f);
        }
        */ 
    }
}
