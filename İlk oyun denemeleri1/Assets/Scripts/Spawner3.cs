using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag=="karakter")
        {
            SceneManager.LoadScene(3);
            Score.yildizpuani_int=0;
        }
    }
}
