using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public Action currentAction { get; protected set; }

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
            Destroy(action.gameObject);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
