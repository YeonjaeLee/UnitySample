using UnityEngine;
using System.Collections;

public class Cameras : MonoBehaviour {

    public GameObject Characters;

	// Use this for initialization
	void Start () {

        transform.position = Characters.transform.position;//캐릭터 좌표 받기
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Characters.transform.position;//지속적으로 캐릭터 좌표 받기

	
	}
}
