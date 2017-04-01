using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour {

    float speed = 2f; //속도
    //bullet
    public GameObject laser = null;//레이저 담을 gameobject 변수

    //적과 충돌
    public int hp = 3;
    bool isDie = false;
    public Image[] hpBar = null;
    public Button replayBtn = null;

    public void PlayerHit()
    {
        if (hp == 2) hpBar[2].gameObject.SetActive(false);
        if (hp == 1) hpBar[1].gameObject.SetActive(false);
        if (hp == 0) hpBar[0].gameObject.SetActive(false);

        if (hp <= 0)
        {
            replayBtn.gameObject.SetActive(true);
            isDie = true;
        }
    }

    //// use this for initialization
    //void start () {
	
    //}

    // Update is called once per frame
    void Update()
    {
        if (isDie == true)
        {
            transform.localScale = new Vector2(transform.localScale.x - 0.01f, transform.localScale.y - 0.01f);
            transform.Rotate(new Vector3(0, 0, 10));
            if (transform.localScale.x <= 0)
            {
                Destroy(this.gameObject);
            }
        }

        else if (isDie == false)
        {
            if (Input.GetKey(KeyCode.LeftArrow)) // 왼쪽을 눌렀다면
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime); // 왼쪽으로 speed만큼 이동
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime); // 오른쪽으로 speed만큼 이동
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime); //위로 speed만큼 이동
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime); //아래로 speed만큼 이동
            }
            if (Input.GetKeyDown(KeyCode.Space)) //스페이스바 눌렀다면
            {
                Instantiate(laser, this.transform.position, Quaternion.identity);
                //레이저를 자기 자신의 위치에서 생성한다
            }
        }

    }
}
