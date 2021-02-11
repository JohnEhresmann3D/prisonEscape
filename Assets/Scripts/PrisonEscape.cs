using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonEscape : MonoBehaviour
{
    public Text textComponent;

    //1. New User Experience
    void Start() {
        New_User();
    }

    void New_User() {
        
        textComponent.text = "Welcome to Prison escape!\n\nPress [Enter] key to continue";
        if (Input.GetKey(KeyCode.Return)) {
            Prison_Game();
        }
        

    }

    void Prison_Game() {
    
    //2. Room 1
    
    
    //3. Room 2
    
    //4. Room 3
    
    //5. End of Game

    }
   
    


}