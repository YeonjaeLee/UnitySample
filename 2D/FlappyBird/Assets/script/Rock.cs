using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 5f);

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * 5 * Time.deltaTime);
	
	}
}
