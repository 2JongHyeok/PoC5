using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float moveSpeed = 1.0f; // 비눗방울이 위로 떠오르는 속도
    public float lifeTime = 5.0f;  // 비눗방울이 사라지기까지의 시간

    [HideInInspector] // 인스펙터에서 숨기지만 코드에서는 접근 가능
    public GameObject containedObject = null; // 비눗방울 안에 담긴 오브젝트 (플레이어 또는 다른 물체)

    void Start()
    {
        // lifeTime 후에 게임 오브젝트를 파괴합니다.
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // 위쪽으로 계속 움직입니다.
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 현재는 어떤 충돌이든 비눗방울을 터뜨립니다.
        // 나중에 '비눗물이 묻지 않은 벽'과 '플레이어' 충돌 로직을 추가할 예정입니다.
        Destroy(gameObject);
    }
}
