using UnityEngine;

public class B7 : MonoBehaviour
{
    //Vector2 target = new Vector2(8, 1.5f);
    void Update()
    {
        //1. Movetowards
        //transform.position = Vector2.MoveTowards(transform.position, target, 1f); //  등속이동, 파라미터 : (현재위치, 목표위치, 속도)

        //2. SmoothDamp <- 참조속도 추가 // 마지막 파라미터에 반비례하여 속도 증가
        //Vector2 valo = Vector2.zero;
        //transform.position = Vector2.SmoothDamp(transform.position, target, ref valo,1f);

        //3. Lerp // 마지막 파라미터에 비례하여 속도 증가
        //transform.position = Vector2.Lerp(transform.position, target, 0.05f);

        //4. Slerp (구면 선형 보간)
        //transform.position = Vector2.Slerp(transform.position, target, 0.1f); // 2차원에서는 사용 불가

        ////5. 델타타임 : 프레임이 높든 적은 나오는 값이 같게
        //Vector2 target = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical") * Time.deltaTime);
        //transform.Translate(target);
    }
}
