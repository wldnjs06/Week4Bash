using Unity.VisualScripting;
using UnityEngine;

public class B10 : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        // 1. 속도 주기
        rigid = GetComponent<Rigidbody>();
        //rigid.linearVelocity = Vector3.left;
        //rigid.linearVelocity = new Vector3(2, 4, 3);

        //2. 힘 주기
        //rigid.AddForce(Vector3.up * 5, ForceMode.Impulse); // mass의 영향을 받음
    }

    // Update is called once per frame
    void FixedUpdate() // RigidBody에 관한 정보는 Fixedupdate에 작성
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            Debug.Log(rigid.linearVelocity);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        //3. 회전력 주기
        //rigid.AddTorque(Vector3.back);
        //rigid.AddTorque(Vector3.up);

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }

}
