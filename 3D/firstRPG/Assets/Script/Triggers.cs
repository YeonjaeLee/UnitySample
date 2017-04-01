using UnityEngine;
using System.Collections;

public class Triggers : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider order)
    {
        if (order.gameObject.tag == "Player")
        {
            Debug.Log("플레이어 들어옴");
        }
        else if (order.gameObject.tag == "Monster")
        {
            Debug.Log("몬스터");
        }


    }

    void OnTriggerStay(Collider order)
    {
        

    }

    void OnTriggerExit(Collider order)
    {
        if (order.gameObject.tag == "Player")
        {
            Debug.Log("플레이어 나감");
        }
    }

}
