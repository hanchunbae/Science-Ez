using UnityEngine;

public class Stage4Choose : MonoBehaviour
{
    public void Stage4Button()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Stage4");
        Debug.Log("Stage 4 Button Clicked");
    }
}
