using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public Animation Any;

    public CharacterController CC;

    RaycastHit Hit; //광선 맞는 부분값 받는 변수

    float MoveSpeed;
    Vector3 Click;

	// Use this for initialization
	void Start () {
        CC = GetComponent<CharacterController>();

        MoveSpeed = 5f;
        //Any.Play("Idle"); //움직임 부자연스러움
        Any.CrossFade("Idle",0.25f); //좀더 자연스러움. 애니메이션 사이 간격 설정
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0)) //클릭했을때
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out Hit);

//            Click = Hit.point; //2차원 좌표를 3차원 좌표 변환
//            transform.Translate((Click - transform.position).normalized * MoveSpeed * Time.deltaTime ); //크기 무시 방향만
            CC.Move((Hit.point - transform.position).normalized * MoveSpeed * Time.deltaTime);
            CC.Move(new Vector3(0, -0.5f, 0));

            Any.CrossFade("Walk", 0.25f);
            //Any.Play("Walk");
        }else
            Any.CrossFade("Idle", 0.25f);
            //Any.Play("Idle");

        //CC.Move((Hit.point - transform.position).normalized * MoveSpeed * Time.deltaTime);
        //CC.Move(new Vector3(0, -0.5f, 0));
	
	}
}
