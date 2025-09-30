using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameReStart : MonoBehaviour
{
    public string SceneName;  //ºÒ·¯¿Ã¾À
    void Start()
    {

    }

    void Update()
    {

    }
    public void Load()
    {
        SceneManager.LoadScene(SceneName);
    }
}
