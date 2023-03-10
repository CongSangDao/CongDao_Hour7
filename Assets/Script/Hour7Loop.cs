using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hour7Loop : MonoBehaviour
{
    void Start()
    {
        int birthdayMonth = 10;
        int birthdayDay = 25;

        for (int i = 1; i <= 12; i++)
        {
            if (i == birthdayMonth)
            {
                Debug.Log("It's my birthday month!");
            }
            else
            {
                Debug.Log(i);
            }
        }
        
        if (birthdayMonth == 10) 
        {
         for(int i = 1; i <= 31; i++)
            { 
                if( i == 25)
                {
                    Debug.Log("it's my birthday day!");
                }
                else
                {
                    Debug.Log(i);
                }
            }
        }
       
            
        }
    // Update is called once per frame
    void Update()
    {

    }
}



