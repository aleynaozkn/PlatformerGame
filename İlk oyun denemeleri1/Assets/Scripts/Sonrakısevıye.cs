using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sonrakısevıye : MonoBehaviour
{
   public void sonrakiseviyebutton()
   {
       SceneManager.LoadScene(2);
       Score.yildizpuani_int=0;
   }
}
