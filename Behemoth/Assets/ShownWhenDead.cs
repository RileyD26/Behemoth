using UnityEngine;

public class ShownWhenDead : MonoBehaviour
{
    public GameObject retryGameCanvas;
    public Transform player;
    public Transform enemy;
    public float detectionRadius = 2.5f;

    bool isPlayerInRange = false;

    void Update()
    {
        if (player == null || enemy == null || retryGameCanvas == null)
        {
            Debug.LogError("Assign Canvas.");
            return;
        }

        float distanceToPlayer = Vector3.Distance(player.position, enemy.position);

        if (distanceToPlayer <= detectionRadius)
        {
            isPlayerInRange = true;
        }
        else
        {
            isPlayerInRange = false;
        }

        if (isPlayerInRange)
        {
            ActivateRetryGameCanvas();
        }
        else
        {
            DeactivateRetryGameCanvas();
        }
    }

    void ActivateRetryGameCanvas()
    {
        retryGameCanvas.SetActive(true);
    }

    void DeactivateRetryGameCanvas()
    {
        retryGameCanvas.SetActive(false);
    }
}