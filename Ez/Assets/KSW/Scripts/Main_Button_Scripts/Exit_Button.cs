using UnityEngine;

public class Exit_Button : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.LogError("게임 종료");
        Application.Quit();
        Debug.Log("Game is exiting...");
    }
}
