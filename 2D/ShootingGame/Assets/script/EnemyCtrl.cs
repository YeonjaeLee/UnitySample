using UnityEngine;
using System.Collections;

public class EnemyCtrl : MonoBehaviour {

    //추락모션
    bool isHit = false;
    BoxCollider2D bc = null;
    PlayerCtrl pc = null;
    float randomSpeed = 0f;
    private GameManager gm = null;
    void Awake()
    {
        bc = GetComponent<BoxCollider2D>();
        pc = GameObject.FindWithTag("Player").GetComponent<PlayerCtrl>();
        randomSpeed = Random.Range(5f, 20f);
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D coll) // 충돌체크함수
    {
        if (coll.gameObject.tag == "BULLET") //만약 충돌한 태그가 BULLET라면
        {
            Destroy(coll.gameObject);//총알 삭제
            //Destroy(this.gameObject);//본인 삭제
            isHit = true;
            gm.ScoreUp(1);
        }
        else if (coll.gameObject.tag == "Player")
        {
            isHit = true;
            pc.hp -= 1;
            pc.PlayerHit();
        }
    }

    //// Use this for initialization
    //void Start () {
	
    //}

    // Update is called once per frame
    void Update()
    {
        if (isHit == false)
        {
            transform.Translate(Vector2.down * Time.deltaTime * randomSpeed);
            if (transform.position.y <= -10)
            {
                Destroy(this.gameObject);
            }
        }

        if (isHit == true)
        {
            bc.enabled = false;
            transform.localScale = new Vector2(transform.localScale.x - 0.01f, transform.localScale.y - 0.01f);//스케일 작아짐
            transform.Rotate(new Vector3(0, 0, 10));//계속 회전함
            if (transform.localScale.x <= 0)
            {
                Destroy(this.gameObject);
            }
        }

    }
}
