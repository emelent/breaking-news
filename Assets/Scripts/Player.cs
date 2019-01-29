using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ClickBox clickBox;

    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        handleKeyboard();   
    }

    void handleKeyboard(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            if(clickBox.currentAction != null){
                spriteRenderer.color = Color.green;
            } else {
                spriteRenderer.color = Color.red;
            }
        } else if(Input.GetKeyUp(KeyCode.UpArrow)){
            spriteRenderer.color = Color.white;
        }
    }
}
