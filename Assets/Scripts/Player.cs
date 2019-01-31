using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ClickBox clickBox;
    public AudioSource hit;
    public AudioSource miss;
    public ActionSystem actionSystem;

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
        var action = clickBox.currentAction;
        // up
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            if(action != null && action.actionType == Action.ActionType.UP){
                spriteRenderer.color = Color.green;
                hit.Play();
                clickBox.DestroyAction();
            } else {
                spriteRenderer.color = Color.red;
                miss.Play();
                actionSystem.MissAction();
            }
            
            StopAllCoroutines();
            StartCoroutine(ResetPlayerColor());
        }
        
        // down
         else if(Input.GetKeyDown(KeyCode.DownArrow)){
            if(action != null && action.actionType == Action.ActionType.DOWN){
                spriteRenderer.color = Color.green;
                hit.Play();
                clickBox.DestroyAction();
            } else {
                spriteRenderer.color = Color.red;
                miss.Play();
                actionSystem.MissAction();
            }
            
            StopAllCoroutines();
            StartCoroutine(ResetPlayerColor());
        }
        // left
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            if(action != null && action.actionType == Action.ActionType.LEFT){
                spriteRenderer.color = Color.green;
                hit.Play();
                clickBox.DestroyAction();
            } else {
                spriteRenderer.color = Color.red;
                miss.Play();
                actionSystem.MissAction();
            }
            
            StopAllCoroutines();
            StartCoroutine(ResetPlayerColor());
        } 

        // right
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            if(action != null && action.actionType == Action.ActionType.RIGHT){
                spriteRenderer.color = Color.green;
                hit.Play();
                clickBox.DestroyAction();
            } else {
                spriteRenderer.color = Color.red;
                miss.Play();
                actionSystem.MissAction();
            }
            StopAllCoroutines();
            StartCoroutine(ResetPlayerColor());
        } 
    }

    IEnumerator ResetPlayerColor(){
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.color = Color.white;
    }
}
