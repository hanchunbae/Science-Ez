using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{
    public void StartGameScene()
    { 
        SceneManager.LoadScene("Stage_Choose");
        Debug.Log("Start Game Button Clicked");
    }
}
