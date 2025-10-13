using UnityEngine;

public class Stage1Choose : MonoBehaviour
{
   public void Stage1Button()
   {
       UnityEngine.SceneManagement.SceneManager.LoadScene("Stage1");
       Debug.Log("Stage 1 Button Clicked");
    }
}
