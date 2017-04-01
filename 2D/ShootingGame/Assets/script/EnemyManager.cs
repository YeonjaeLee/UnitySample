using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
    public GameObject[] enemys = null;

	// Use this for initialization
	void Start () {
        StartCoroutine(EnemyCreate());

	
	}

    IEnumerator EnemyCreate()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.4f);
            Instantiate(enemys[Random.Range(0, 4)], new Vector2(Random.Range(-3.3f, 3.3f), 8f), Quaternion.identity);
        }
    }
	
    //// Update is called once per frame
    //void Update () {
	
    //}
}
