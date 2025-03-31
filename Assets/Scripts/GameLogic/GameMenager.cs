using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject[] tetrisBlockPrefabs;
    public Transform spawnPoint;
    private int score = 0;
    private bool isTriggered = false;
    private GameObject currentBlock; // Store the latest block

    void Start()
    {
        StartCoroutine(WaitForSpawn());
    }

    void SpawnTetrisBlock()
    {
        int index = Random.Range(0, tetrisBlockPrefabs.Length);
        currentBlock = Instantiate(tetrisBlockPrefabs[index], spawnPoint.position, Quaternion.identity);
        isTriggered = false; // Reset trigger after spawning
        StartCoroutine(WaitForSpawn()); // Restart waiting
    }

    IEnumerator WaitForSpawn()
    {
        // Wait indefinitely until triggered, but spawn after 5 seconds if not triggered
        float elapsedTime = 0f;
        while (!isTriggered && elapsedTime < 5f)
        {
            elapsedTime += Time.deltaTime;
            yield return null; // Wait until next frame
        }

        SpawnTetrisBlock(); // Spawn block after timeout or trigger
    }

    public void TriggerSpawn()
    {
        isTriggered = true; // External trigger
    }

    public void AddScore(int amount)
    {
        score += amount;
    }

    public int GetScore()
    {
        return score;
    }

    public TetrisBlock GetCurrentBlock()
    {
        return currentBlock?.GetComponent<TetrisBlock>();
    }
}