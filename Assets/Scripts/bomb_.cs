using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_ : MonoBehaviour
{
    public MeshRenderer smr_0;
    public MeshRenderer smr_1;
    public Collider collider;
    public AudioSource _as;
    public ParticleSystem _ps; 




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    bool for_once=false;

    void OnTriggerStay(Collider other) 
    {
        if(other.CompareTag("Player") && gun.popper && !for_once)
        { 
            collider.isTrigger=false;
            _as.Play();
            smr_0.enabled=false;
            smr_1.enabled=false;
            camera_.vib_bool=true;
            if(gun.fuel>11) gun.fuel-=10;
            for_once=true;
        }
    }
}
