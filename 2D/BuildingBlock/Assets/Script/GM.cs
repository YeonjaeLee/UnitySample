using UnityEngine;
using System.Collections;

//8-1
using UnityEngine.UI;

public class GM : MonoBehaviour {

    //1
    static public bool isTouch = false;

    //6-1
    static public bool isGameOver = false;

    //7-1
    static public float speed = 5;

    //8-2
    static public int score = 0;

    //2-1 3-1
    public GameObject[] blockPrefab = null;

    //9-1
    public GameObject replayBtn = null;

    //8-3
    public Text scoreText = null;

    //3-2
    int blockColor = 0;

    //4-1
    float blockY = 1.5f;

	// Use this for initialization
	void Start () {
        //9-2
        isGameOver = false;
        speed = 5;
        score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
        
        //2
        if (Input.anyKeyDown)
        {
            //6-2
            if (isTouch == false && isGameOver == false)
            {
                isTouch = true;
                StartCoroutine(BlockCreate());
            }



            //isTouch = true;

            ////5-4
            //StartCoroutine(BlockCreate());

            ////2-2 3-3 4-2
            //Instantiate(blockPrefab[blockColor], new Vector2(0,blockY), Quaternion.identity);

            ////3-4
            //blockColor++;
            
            ////4-3
            //blockY += 1.5f;
            
            ////3-5
            //if (blockColor > 4) blockColor = 0;

            //9-3
            if (isGameOver == true)
            {
                //9-4
                replayBtn.SetActive(true);
            }
        }
	
	}

    //5-1
    IEnumerator BlockCreate()
    {
        //5-2
        yield return new WaitForSeconds(0.5f);

        //5-3
        Instantiate(blockPrefab[blockColor], new Vector2(0, blockY), Quaternion.identity);
        blockColor++;
        if (blockColor > 4) blockColor = 0;

        blockY += 1.5f;

        //7-2
        speed += 0.5f;

        //8-4
        score++;
        //8-5
        scoreText.text = "SCORE : " + score.ToString();

        
    }

    //9-5
    public void Replay()
    {
        //9-6
        Application.LoadLevel("GameScene");
    }

}
