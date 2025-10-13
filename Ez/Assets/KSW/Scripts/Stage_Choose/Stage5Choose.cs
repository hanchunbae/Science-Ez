using UnityEngine;

public class Stage5Choose : MonoBehaviour
{
   public void Stage5Button()
   {
       UnityEngine.SceneManagement.SceneManager.LoadScene("Stage5");
       Debug.Log("Stage 5 Button Clicked");
    }
}
