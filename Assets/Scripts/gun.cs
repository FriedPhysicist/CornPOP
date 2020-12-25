using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public static bool popper=false;
    public Rigidbody rb;
    public Collider cl_;
    public ParticleSystem ps;
    public AudioSource _as; 
    public static bool finish;
    public static int fuel=0;
    public static int fuel_GUI=0;





    void Start()
    { 
        fuel=0;
        fuel_GUI=0;
        finish=false;
    }


    void Update()
    {
        if(Input.touchCount>0)
        { 
            Touch touch=Input.GetTouch(0);

            //if popper equals to true, that mean you are firing.
            if(touch.phase==TouchPhase.Began) 
            {
                popper=true; 
                if(!_as.isPlaying) _as.Play();
                ps.Play();
            }

            if(touch.phase==TouchPhase.Ended) 
            {
                popper=false;
                _as.Stop();
                ps.Stop();
            } 
        }

        //if popper equals to true, that mean you are firing.
        if(Input.GetMouseButtonDown(0)) 
        {
            popper=true; 
            if(!_as.isPlaying) _as.Play();
            ps.Play();
        }

        if(Input.GetMouseButtonUp(0)) 
        {
            popper=false;
            _as.Stop();
            ps.Stop();
        } 
    }

    void OnTriggerEnter(Collider other) 
    { 
        if(other.CompareTag("Finish"))
        { 
            finish=true;
        }
    }
}
