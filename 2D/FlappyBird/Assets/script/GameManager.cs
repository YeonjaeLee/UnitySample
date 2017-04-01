using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject rock = null;

	// Use this for initialization
	void Start () {
        StartCoroutine(CreatRock());
	
	}

    IEnumerator CreatRock()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.8f,1.3f));
            Instantiate(rock, new Vector2(10,Random.Range(-1.7f,1.6f)), Quaternion.identity);
            
            //Instantiate(rock, Vector2.one, Quaternion.identity);
            //장애물 생성 위치는 0 회전값 변함없음
        }
    }
	
    //// Update is called once per frame
    //void Update () {
	
    //}
}
