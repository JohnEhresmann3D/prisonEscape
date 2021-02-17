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

        ManageState();
        
    }

    private void ManageState() {
        var nextStates = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2)) {
            state = nextStates[1];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3)) {
            state = nextStates[2];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4)) {
            state = nextStates[3];
        }
        else {
            print ("Please enter a valid selection");
            ManageState();
        }
    }

}