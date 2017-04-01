using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {

    RaycastHit Hit; //광선 맞는 부분값 받는 변수

    float TurnSpeed;
    Vector3 Click;

    Quaternion dir;//회전

    // Use this for initialization
    void Start()
    {

        TurnSpeed = 5f;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0)) //클릭했을때
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out Hit);

            Click = Hit.point; //2차원 좌표를 3차원 좌표 변환

            dir = Quaternion.LookRotation((Click - transform.position).normalized);//보는방향으로

            dir.x = 0;//Character이 기울지않게

            dir.z = 0;

            transform.rotation = Quaternion.Slerp(transform.rotation, dir , TurnSpeed * Time.deltaTime);//회전 및 회전속도조절
        }

    }
}
