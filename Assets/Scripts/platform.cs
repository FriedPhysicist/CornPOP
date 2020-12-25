using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
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

    public static bool game_over=false;
    



    void Start()
    {
        //find all popcorns in scene
        total_corn=GameObject.FindGameObjectsWithTag("pop_corn").Length; 
        step=150/(total_corn);
        game_over=false;
        game_over_canvas.enabled=false;
        next_level.enabled=false;
    }

    void Update() 
    {  
        if(!game_over) GUI_();
        Canvas_(); 
    }


    void FixedUpdate()
    { 
        if(!game_over) 
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
                next_level.enabled=true;
            }
        }
    }

    void GUI_()
    { 
        point_.value=point_value;
        score_number.text=gun.fuel_GUI.ToString(); 
        if(point_value>0) point_.value-=0.1f; 
        sliced_number.text=multiply_value.ToString();
    }



    public Canvas game_over_canvas;
    public Canvas next_level;
    public Canvas score_canvas;

    public void Canvas_()
    { 
        game_over_canvas.enabled=game_over;
    }

    public void retry_button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void menu_button()
    {
        SceneManager.LoadScene("menu");
    }

    public void next_level_button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
