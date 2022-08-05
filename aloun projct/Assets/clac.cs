using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clac : MonoBehaviour
{
    string heroname = "abdulaziz";
        int heroPower = 2000;
    string villainName = "taleb";
        int villainPower = 1500;
        float plairSpeed = 4.4f;
    // Start is called before the first frame update
    void Start()
    {
        SetSPEED(8.5f);

        if (heroPower > villainPower)

        { print("heroPower"); }


        else if (heroPower < villainPower)


        { print("villainPower"); }

        else
        {
            print("strong");


        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetSPEED (float newSpeed)
       {
        print(plairSpeed );
    plairSpeed  = newSpeed;
        print(plairSpeed );

}




       


}
