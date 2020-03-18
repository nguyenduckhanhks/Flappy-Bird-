using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public float oldPosition;
    public float speed; 
    void Start()
    {
        obj = gameObject;
        oldPosition = 20;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1*Time.deltaTime*speed,0,0));
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag.Equals("end")){
            obj.transform.position = new Vector3(oldPosition, Random.Range(-1,2), 0);
        }
    }
}
