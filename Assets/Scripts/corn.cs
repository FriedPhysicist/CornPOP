using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corn : MonoBehaviour
{
    public Mesh new_mesh;
    public MeshFilter change;
    public Material new_material;
    public MeshRenderer meshRenderer;
    public Rigidbody rb;
    public AudioSource _as;

    


    void Start()
    {

    }


    void Update()
    { 
        
    }

    void FixedUpdate() 
    { 
        if(reduce_size_protect) transform.GetChild(1).transform.Rotate(1f,1f,1f);
    }

    bool reduce_size_protect=false;
    void OnTriggerStay(Collider other) 
    {
        if(other.CompareTag("Player") && gun.popper)
        { 
            if(!reduce_size_protect)
            {
                meshRenderer.material=new_material;
                change.mesh=new_mesh; 
                transform.localScale*=1.0f; 
                if(Random.Range(0,101) >60) _as.Play();
                gun.fuel_GUI++;
                if(!gun.finish) gun.fuel++;
                Destroy(gameObject,5f); 
            } 

            reduce_size_protect=true; 
            rb.AddForce(new Vector3(Random.Range(-3,0),Random.Range(0,3),Random.Range(2,6))*3,ForceMode.Impulse);
        }
    }

}
