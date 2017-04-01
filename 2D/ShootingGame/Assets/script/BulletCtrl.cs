using UnityEngine;
using System.Collections;

public class BulletCtrl : MonoBehaviour {

    float speed = 10f;

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 1f); //1초뒤에 자기 자신을 삭제

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
	
	}
}
