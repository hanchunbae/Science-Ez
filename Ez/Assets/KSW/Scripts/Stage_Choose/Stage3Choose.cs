using UnityEngine;

public class Stage3Choose : MonoBehaviour
{
    public void Stage3Button()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Stage3");
        Debug.Log("Stage 3 Button Clicked");
    }
}
