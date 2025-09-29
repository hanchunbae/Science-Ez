using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{
    public void StartGameScene()
    { 
        SceneManager.LoadScene("GameScene");
        Debug.Log("Start Game Button Clicked");
    }
}
