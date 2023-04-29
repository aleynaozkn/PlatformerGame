using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag=="karakter")
        {
            SceneManager.LoadScene(1);
            Score.yildizpuani_int=0;
        }
    }
}
