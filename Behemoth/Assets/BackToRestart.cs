using UnityEngine;

public class BackToRestart : MonoBehaviour
{
    public Transform player;
    public float enemyDetectionRange = 15.61f;
    public float retryRange = 2f;

    bool isPlayerInRange = false;

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= enemyDetectionRange)
        {
            isPlayerInRange = true;
        }
        else
        {
            isPlayerInRange = false;
        }

        if (isPlayerInRange && distanceToPlayer <= retryRange)
        {
            ShowRetryGame();
        }
    }

    void ShowRetryGame()
    {
    }
}