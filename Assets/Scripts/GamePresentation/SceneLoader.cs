using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        // Load the GameLogic scene additively (without unloading GamePresentation)
        SceneManager.LoadScene("GameLogic", LoadSceneMode.Additive);
    }
}