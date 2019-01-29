using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ClickBox clickBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        handleKeyboard();   
    }

    void handleKeyboard(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            if(clickBox.currentAction != null){
                print("Got it");
            } else {
                print("Nothing");
            }
        }
    }
}
