using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escena : MonoBehaviour
{
    public void Escena()
    {
        StopAllCoroutines();
        Resources.UnloadUnusedAssets();
        SceneManager.LoadScene("Scene1");
    }
}
