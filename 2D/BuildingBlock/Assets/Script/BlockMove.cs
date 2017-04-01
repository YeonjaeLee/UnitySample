using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour {
    
    //1
    Rigidbody2D rigidbody2d = null;

    //2-1
    bool isRight = true;

	// Use this for initialization
	void Start () {

        //2
        rigidbody2d = GetComponent<Rigidbody2D>();

        //3
        rigidbody2d.gravityScale = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

        //3-1
        if (GM.isTouch == true)
        {

            //3-2
            rigidbody2d.gravityScale = 1;

            //3-3
            GM.isTouch = false;

            //3-4
            enabled = false;
        }

        //2-5
        Move();
	
	}

    //2-2
    void Move()
    {
        //2-3
        if (this.transform.position.x < -3)
            isRight = true;
        else if (this.transform.position.x > 3)
            isRight = false;

        //2-4 4-1
        if (isRight == true)
            this.transform.Translate(Vector2.right * GM.speed * Time.deltaTime, Space.World);
        else if (isRight == false)
            this.transform.Translate(-Vector2.right * GM.speed * Time.deltaTime, Space.World);
    }
}
