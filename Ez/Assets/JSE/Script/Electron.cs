using Unity.VisualScripting;
using UnityEngine;

public class Electron : MonoBehaviour
{
    public float charge = 1f;       // 공의 전하 (양수/음수)
    public float k = 0f;          // 힘 크기 조절용 상수
    public Rigidbody2D rb;

    public GameObject reset;

    void FixedUpdate()
    {
        Charge[] charges = FindObjectsOfType<Charge>();// 장면에 있는 모든 전하 찾기

        Vector2 netForce = Vector2.zero;

        for (int i = 0; i < charges.Length; i++)
        {
            Charge c = charges[i];
            if (c == null) continue;
            
            Vector2 dir = (c.transform.position - transform.position);// 공 → 전하 방향 벡터

            float r = dir.magnitude;// 거리

            if (r < 2f) r = 2f;// 너무 가까우면 폭발하니까 최소 거리 보정

            dir = dir.normalized;// 단위 벡터 (방향만)

            float forceMag = k * charge * c.charge / (r * r);// 쿨롱 힘 크기 (1 / r^2 때문에 멀어질수록 힘이 줄어듦)

            Vector2 force = dir * forceMag;// 방향 × 크기 = 최종 힘

            netForce += force;// 모든 전하가 주는 힘 더하기
        }
        rb.AddForce(netForce);// Rigidbody2D에 힘 적용 → 공이 움직임
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            GameEnd();
        }
        if (collision.gameObject.CompareTag("DeadZone"))
        {
            GameEnd();
        }
    }

    public void GameStart()
    {
        k = 300f;
        Time.timeScale = 1f;
        reset.SetActive(false);
    }
    public void GameEnd()
    {
        Time.timeScale = 0f;
        Debug.Log("게임 끝 UI");
        GameRestart();
        
    }
    public void GameRestart()
    {
        Reset();
        k = 0;
        Time.timeScale = 0f;
        transform.position = Vector3.zero;
        reset.SetActive(true);
    }
    public void Reset()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("charges");

        foreach (GameObject obj in objects)
        {
            Destroy(obj);
        }
    }
}
