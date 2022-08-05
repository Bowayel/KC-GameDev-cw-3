using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    //define informaition
    string heroname = "hasson";
    int heropower = 40;
    string villainname = "madry";
    int villainpower = 55;
    float playerspeed = 30f;
    float newspeed = 2.5f;



    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villainpower)
        {
            print(" the hero has more power");
        }

        else if (heropower == villainpower)
        {
            print("they are equal");
        }

        else
        {
            print("the villain has more power");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void setspeed(float newspeed)
    {
        print("old speed is" + playerspeed);
        playerspeed = newspeed;
        print("new speed is" + playerspeed);
    }
}
