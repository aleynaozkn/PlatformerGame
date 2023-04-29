using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oyunubitir : MonoBehaviour
{
    public void oyunubıtır()
    {
        SceneManager.LoadScene(3);
        Score.yildizpuani_int=0;

    }
}
