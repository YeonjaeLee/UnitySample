using UnityEngine;
using System.Collections;

public class GroundCollision : MonoBehaviour {

    //// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
	
    //}

    //1-1
    void OnCollisionEnter2D(Collision2D coll)
    {
        //1-2
        if (coll.gameObject.tag == "BLOCK")
        {
            //2-1
            GM.isGameOver = true;

            //1-3
            print("GameOver!!");
        }
    }

}
