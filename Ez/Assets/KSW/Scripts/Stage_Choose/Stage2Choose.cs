using UnityEngine;

public class Stage2Choose : MonoBehaviour
{
    public void Stage2Button()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Stage2");
        Debug.Log("Stage 2 Button Clicked");
    }
}
