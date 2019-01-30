using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ActionPrefab;
    public Transform spawnPoint;
    public float actionSpeed;
    public float actionSpawnDelay = 0.5f;
    public float sequenceDelay = 2f;
    public int minSequenceLength = 2;
    public int maxSequenceLength = 7;
    public bool isActive = false;
    public ClickBox clickBox;

    public int level = 1;

    int combo = 0;
    
    float timeStarted;
    bool spawning = false;
    float timeOfLastError;
    void Start(){
        // StartCoroutine(spawnSequence());
    }

    void Update(){
        if(!spawning && isActive){
            spawning = true;
            StartCoroutine(delayedSpawn());
        }        
    }


    IEnumerator spawnSequence(){
        int len = Random.Range(minSequenceLength, maxSequenceLength);
        for(int i=0; i < len; i++){
            var actionObject = Instantiate(ActionPrefab, spawnPoint.position, spawnPoint.transform.rotation);
            Action action = actionObject.GetComponent<Action>();
            action.SetActionType((Action.ActionType) Random.Range(0, 4));
            action.speed = actionSpeed;
            action.clickBox = clickBox;
        
            yield return new WaitForSeconds(actionSpawnDelay);
        }
        spawning = false;
    }

    IEnumerator delayedSpawn(){
        yield return new WaitForSeconds(sequenceDelay);
        StartCoroutine(spawnSequence());
    }

    void levelUp(){

    }

    public void StartSystem(){
        timeStarted = Time.time;
        timeOfLastError = timeStarted;
        isActive = true;
    }

    public void StopSystem(){
        isActive = false;
    }
}
