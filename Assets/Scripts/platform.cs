using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class platform : MonoBehaviour
{


    public float total_corn;
    float step;
    public static bool up_=false;
    static public float last_pos_z;
    float speed;
    public Slider point_;
    public static float point_value;
    public TMP_Text score_number;
    public TMP_Text sliced_number;
    public static int multiply_value=1;

    public GameObject start;
    public GameObject end;
    



    void Start()
    {
        //find all popcorns in scene
        total_corn=GameObject.FindGameObjectsWithTag("pop_corn").Length; 
        step=150/(total_corn);
    }

    void Update() 
    {  
        GUI_();

        /**
        if(point_.value<gun.fuel/total_corn*100 && !gun.finish)
        {
            point_.value+=0.5f;
        } 

        if(gun.finish)
        {
            point_.value=(((last_pos_z-transform.position.z)-step*gun.fuel)/(start.transform.position.z-end.transform.position.z))*100;
        }
        */
    }


    void FixedUpdate()
    { 
        speed=transform.position.z-(last_pos_z-step*gun.fuel);

        if(!gun.finish)
        {
            transform.position-=new Vector3(0,0,0.15f);
            last_pos_z=transform.position.z; 
        }



        if(gun.finish && transform.position.z>last_pos_z-step*gun.fuel && speed/200>0.03f)
        { 
            transform.position-=new Vector3(0,0,speed/200);
        }

        if(gun.finish && speed/200<=0.03f)
        {
            gun.fuel=0;
        }
    }

    void GUI_()
    { 
        point_.value=point_value;
        score_number.text=gun.fuel_GUI.ToString(); 
        if(point_value>0) point_.value-=0.1f; 
        sliced_number.text=multiply_value.ToString();
    }
}
