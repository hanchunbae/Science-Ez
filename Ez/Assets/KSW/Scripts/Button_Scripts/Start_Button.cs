using Unity.VisualScripting;
using UnityEngine;

public class Start_Button : MonoBehaviour
{
    public static class OnButtonClicked
    { 
        public static bool isClicked = false;
    }

    private void Update()
    {
        if (OnButtonClicked.isClicked)
        {
            Debug.Log("버튼은 클릭되지만 실행이 안됨");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
            Debug.Log("Button Clicked");
        }
        else
        {
            Debug.Log("버튼은 클릭됨");
        }
    }
}
