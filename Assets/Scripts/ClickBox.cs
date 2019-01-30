using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBox : MonoBehaviour
{
    public Action currentAction { get; protected set; }
    public GameObject HitParticles;

    void OnTriggerEnter2D(Collider2D collider) {
        Action action = collider.GetComponent<Action>();
        if(action != null){
            currentAction = action;
        }
    }

    void OnTriggerExit2D(Collider2D collider) {
        Action action = collider.GetComponent<Action>();
        if(action == currentAction){
            currentAction = null;
            action.enabled = false;
            // Instantiate(HitParticles, action.transform.position, action.transform.rotation);
            Destroy(action.gameObject);
        }
    }

    public void DestroyAction(){
        if(currentAction == null) return;
    
        currentAction.enabled = false;
        Instantiate(HitParticles, currentAction.transform.position, currentAction.transform.rotation);
        Destroy(currentAction.gameObject);
        currentAction = null;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
