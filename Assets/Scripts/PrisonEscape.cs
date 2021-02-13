using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonEscape : MonoBehaviour
{
    [SerializeField] State startingState;
    [SerializeField] Text textComponent;

    State state;

    //1. New User Experience
    void Start() {
        state = startingState;
        textComponent.text = state.GetStateStory();

        
    }

    void Update() {
        New_User();

    }

    void New_User() {
        
        
        

    }

    void Prison_Game() {
    //string game_text;

    print("this is a test");

    //2. Room 1
    
    
    //3. Room 2
    
    //4. Room 3
    
    //5. End of Game

    }
   
    


}