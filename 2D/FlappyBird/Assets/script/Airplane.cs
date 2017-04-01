using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Airplane : MonoBehaviour {

    Rigidbody2D rig = null;
    public Text scoreText = null;
    int score = 0;

    void Awake()//게임시작전 호출 함수
    {
        rig = this.GetComponent<Rigidbody2D>();
        score = 0;
    }

    //// Use this for initialization
    //void Start () {
	
    //}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown) //아무키나 눌르면
        {
            rig.velocity = Vector2.zero;//rigibody 의 속도는 0
            rig.AddForce(Vector2.up * 4f, ForceMode2D.Impulse);//리지드바디에 힘을 더해 위로 올림

            //Debug.Log("터치함!!");
        }
	
	}

    void OnTriggerEnter2D(Collider2D coll)//물리적 충돌이 아닌 충돌 발생시(관통)
    {
        if (coll.gameObject.name == "Coin")//충돌한 이름이 Coin이면
        { 
            score += 1;//스코어 +1
            scoreText.text = "Score : " + score.ToString();//스코어값 출력
            Destroy(coll.gameObject);//충돌된 오브젝트 삭제
         }
    }

    void OnCollisionEnter2D(Collision2D coll) //물리적인 충돌시 충돌 발생
    {
        if (coll.gameObject.name == "rock" || coll.gameObject.name == "rockDown") // 충돌한게 rock rockDown 이면
        {
            Time.timeScale = 0.3f;//게임속도 느리게
            StartCoroutine(NewSceneLoad()); // 코루틴 함수 실행
        }
    }

    IEnumerator NewSceneLoad() //코루틴 함수
    {
        yield return new WaitForSeconds(1f);//코루틴 함수는 다음과 같이 몇초뒤에 실행 가능
        Time.timeScale = 1f;//게임속도 정상으로
        Application.LoadLevel("GameScene");//씬로드
    }
}
