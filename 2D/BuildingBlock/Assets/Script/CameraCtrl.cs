using UnityEngine;
using System.Collections;

public class CameraCtrl : MonoBehaviour {


    //1-1
    Vector3 cameraY = new Vector3(0, 2, 0);

    //1-2
    void OnTriggerEnter2D(Collider2D coll)
    {
        //1-3
        if (coll.gameObject.tag == "BLOCK")
        {
            //1-4
            this.transform.position += cameraY;
        }
    }


    //// Use this for initialization
    //void Start()
    //{

    //}

    //2-1
    // Update is called once per frame
    void Update()
    {
        //2-2
        if (GM.isGameOver)
        {
            //2-3
            StartCoroutine(ZoomOut());
        }

    }

    //2-4
    IEnumerator ZoomOut()
    {
        //2-5
        for (int i = 5; i < GM.score * 3; i++)
        {
            //2-6
            yield return new WaitForSeconds(0.01f);
            //2-7
            GetComponent<Camera>().orthographicSize = i;
        }
    }

}
