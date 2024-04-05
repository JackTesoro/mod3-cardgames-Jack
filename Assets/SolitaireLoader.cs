using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SolitaireLoader : MonoBehaviour
{

    public void LoadMod3Scene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
