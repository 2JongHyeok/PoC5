using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // 플레이어 이동 속도
    public GameObject bubblePrefab; // 생성할 비눗방울 프리팹
    public Transform bubbleSpawnPointLeft; // 왼쪽 비눗방울 생성 위치
    public Transform bubbleSpawnPointRight; // 오른쪽 비눗방울 생성 위치

    void Update()
    {
        // 플레이어 좌우 이동
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);

        // 왼쪽 비눗방울 생성 (예: Q 키)
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SpawnBubble(bubbleSpawnPointLeft.position);
        }

        // 오른쪽 비눗방울 생성 (예: E 키)
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnBubble(bubbleSpawnPointRight.position);
        }
    }

    void SpawnBubble(Vector3 spawnPosition)
    {
        if (bubblePrefab != null)
        {
            Instantiate(bubblePrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Bubble Prefab is not assigned in PlayerController.");
        }
    }
}
