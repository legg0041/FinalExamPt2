using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public void LevelLoad(string name)
    {
        SceneManager.LoadScene(name);
    }
}
