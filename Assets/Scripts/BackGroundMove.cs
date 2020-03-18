using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public GameObject obj;

    public Vector3 oldPosition;
    public float speed;
    public float rangeMove;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;
        speed = 5;
        rangeMove = 20;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1*Time.deltaTime*speed,0,0));
        if(Vector3.Distance(oldPosition,obj.transform.position) > rangeMove){
            obj.transform.position = oldPosition;
        }
    }
}
