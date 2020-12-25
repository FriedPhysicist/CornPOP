using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public AudioSource _as;
    public MeshRenderer _smr;



    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    { 
        if(protect_) transform.GetChild(0).gameObject.transform.Rotate(0f,1f,0f);
    } 


    bool protect_=false;
    void OnTriggerStay(Collider other) 
    { 
        if(other.CompareTag("Player") && gun.popper && !protect_)
        { 
            _as.Play(); 
            _smr.enabled=false;
            protect_=true;
            gun.fuel_GUI+=40;
            Destroy(gameObject,1f);
        } 
    }
}
