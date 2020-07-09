using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Tutorial");
    }

   public void ExitGame()
   {
       Application.Quit();
   }

   public void OptionsMenu()
   {
       
   }
}
