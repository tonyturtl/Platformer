using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public static GameManagement instance;             //static variable that will hold Singleton

   // Called when script instance is being loaded
    void Awake()
     {   
       
        if (instance == null) 
        {                
            DontDestroyOnLoad(gameObject);    
            instance = this;
        }
        
        else                                    //if instance is set to an object
        {                                  
            Destroy(gameObject);
        }
}
}