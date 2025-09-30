using UnityEngine;

public class Electron : MonoBehaviour
{
    public float charge = 1f;       // 공의 전하 (양수/음수)
    public float k = 100f;          // 힘 크기 조절용 상수
    public Rigidbody2D rb;

    void FixedUpdate()
    {
        // 장면에 있는 모든 전하 찾기
        Charge[] charges = FindObjectsOfType<Charge>();

        Vector2 netForce = Vector2.zero;

        // for문으로 charges 배열 돌리기
        for (int i = 0; i < charges.Length; i++)
        {
            Charge c = charges[i];
            if (c == null) continue;
            
            // 공 → 전하 방향 벡터
            Vector2 dir = (c.transform.position - transform.position);

            // 거리
            float r = dir.magnitude;

            // 너무 가까우면 폭발하니까 최소 거리 보정
            if (r < 2f) r = 2f;

            // 단위 벡터 (방향만)
            dir = dir.normalized;

            // 쿨롱 힘 크기 (1 / r^2 때문에 멀어질수록 힘이 줄어듦)
            float forceMag = k * charge * c.charge / (r * r);

            // 방향 × 크기 = 최종 힘
            Vector2 force = dir * forceMag;

            // 모든 전하가 주는 힘 더하기
            netForce += force;
        }

        // Rigidbody2D에 힘 적용 → 공이 움직임
        rb.AddForce(netForce);
    }
}
