using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public string sceneToLoad;

    public void SwitchScene()
    {
        SceneManager.LoadScene(0);
    }
}