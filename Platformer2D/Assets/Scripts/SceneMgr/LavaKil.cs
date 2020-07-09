using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaKil : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D colliderInfo)
    {
        if (colliderInfo.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
