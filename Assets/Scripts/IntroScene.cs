using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
        {         
            LoadMainScene();
        }
    }

    void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }
}
