using UnityEngine;

public class InGameStart : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0f;
        Debug.Log("시간이 흐르지않음");
    }

    public void StartButton()
    {
        Time.timeScale = 1f;
        Debug.Log("시간이 흐름");
    }
}