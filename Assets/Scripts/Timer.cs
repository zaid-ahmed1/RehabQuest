using UnityEngine;

public class Timer : MonoBehaviour
{
    private float startTime;
    private float timer;

    //private float lastSecondPrinted = 0f; // Track the last second printed

    private bool gameRunning = false;

    void Start()
    {
        StartGame();
    }

    void Update()
    {
        if (gameRunning)
        {
            timer = Time.time - startTime;
            Debug.Log(timer);

            /* Check if a second has passed since the last print
            if (Mathf.Floor(timer) > lastSecondPrinted)
            {
                lastSecondPrinted = Mathf.Floor(timer);
                Debug.Log("Timer: " + timer.ToString("F2")); // Display timer value (seconds) in console
            }
            */
        }
    }

    public int getTime() {
        return Mathf.RoundToInt(timer);
    }

    public void StartGame()
    {
        startTime = Time.time;
        gameRunning = true;
        Debug.Log("Game started!");
    }

    public void EndGame()
    {
        gameRunning = false;
        float endTime = Time.time;
        float elapsedTime = endTime - startTime;
        Debug.Log("Game ended! Total time: " + elapsedTime.ToString("F2") + " seconds");
    }
}