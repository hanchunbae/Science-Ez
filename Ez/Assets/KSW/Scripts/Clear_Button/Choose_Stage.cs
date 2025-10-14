using UnityEngine;
using UnityEngine.SceneManagement;

public class Choose_Stage : MonoBehaviour
{
    public void StageChoose()
    { 
        SceneManager.LoadScene("Stage_Select");
    }
}
