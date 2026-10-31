using UnityEngine;

public class B11 : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision) // 충돌 시작
    {
        if (collision.gameObject.name == "MyBall(B10)") {
            mat.color = new Color(0, 0, 0);
        }
        
    }

    //private void OnCollisionStay(Collision collision) // 출돌 중
    //{

    //}

    private void OnCollisionExit(Collision collision) // 출돌 끝
    {
        if (collision.gameObject.name == "MyBall(B10)")
        {
            mat.color = new Color(1, 1, 1);
        }
    }
}
