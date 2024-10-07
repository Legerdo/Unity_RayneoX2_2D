using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 2.0f; // 이동 속도

    public float zMin = 0f;   // Z축 최소값

    public float zMax = 10f;  // Z축 최대값

    public bool movingForward = false; // 이동 방향

    private float t = 0f; // Lerp 보간을 위한 시간 값

    void Update()
    {
        // Lerp를 사용하여 Z축 이동
        if (movingForward)
        {
            t += speed * Time.deltaTime; // Lerp 시간 값 증가
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(zMin, zMax, t));

            if (transform.position.z >= zMax)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
                movingForward = false;
                t = 0f; // 시간 값 초기화
            }
        }
        else
        {
            t += speed * Time.deltaTime; // Lerp 시간 값 증가
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(zMax, zMin, t));

            if (transform.position.z <= zMin)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
                movingForward = true;
                t = 0f; // 시간 값 초기화
            }
        }
    }
}
