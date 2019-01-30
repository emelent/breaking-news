using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public enum ActionType{UP,DOWN,LEFT,RIGHT};

    public ActionType actionType = ActionType.UP;


    public float speed = 1f;
    public ClickBox clickBox { get; set; }

    Rigidbody2D rb;
    SpriteRenderer spriteRender;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb.velocity;
        vel.x = -speed;
        rb.velocity = vel;
    }

    void FixedUpdate() {
        if(clickBox == null) return;
        if(clickBox.currentAction == this){
            spriteRender.color = Color.green;
        } else if(spriteRender.color == Color.green){
            spriteRender.color = Color.red;
        }
    }

    public void SetActionType(ActionType t){
        switch(t){
            case ActionType.LEFT:
                transform.eulerAngles = new Vector3(0, 0, 90);
                break;
            case ActionType.DOWN:
                transform.eulerAngles = new Vector3(0, 0, 180);
                break;
            case ActionType.RIGHT:
                transform.eulerAngles = new Vector3(0, 0, 270);
                break;
            default:
                break;
        }
        actionType = t;
    }
    
}
