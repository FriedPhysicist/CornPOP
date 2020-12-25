using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ : MonoBehaviour
{
    Vector3 start_pos;
    int current_vib;
    public int vib_public;
    public static bool vib_bool=false;


    // Start is called before the first frame update
    void Start()
    { 
        start_pos=transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    { 
        if(vib_bool)
        {
            transform.localPosition+=new Vector3(Random.Range(-1,2),Random.Range(-1,2),Random.Range(0,0));

            current_vib++;
        }

        if(current_vib>=vib_public)
        { 
            transform.localPosition=start_pos;
            vib_bool=false;
            current_vib=0;
        }
    }
}
