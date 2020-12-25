using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public AudioSource _as;
    public MeshRenderer _smr;
    public Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    { 
        transform.GetChild(0).gameObject.transform.Rotate(0f,3f,0f);
    } 


    bool protect_=false;
    void OnTriggerStay(Collider other) 
    { 
        if(other.CompareTag("Player") && gun.popper && !protect_)
        { 
            _as.Play(); 
            protect_=true;
            gun.fuel_GUI+=40; 
            rb.AddForce(new Vector3(Random.Range(-3,0),Random.Range(0,3),Random.Range(2,6))*3,ForceMode.Impulse);
            Destroy(gameObject,5f); 
        } 
    }
}
