using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject gameController;
    private GameObject obj;
    private float flyPower;
    private Animator animator;
    void Start()
    {
        gameController = GameObject.FindWithTag("gameController");
        obj = gameObject;
        flyPower = 20;
        animator = obj.GetComponent<Animator>();
        animator.SetBool("isDead",false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,flyPower));
        }
        animator.SetFloat("flyPower",obj.GetComponent<Rigidbody2D>().velocity.y);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("end")){
            animator.SetBool("isDead",true);
            gameController.GetComponent<GameController>().endGame();
        }
        else{
            gameController.GetComponent<GameController>().getPoint();
        }
    }
}
