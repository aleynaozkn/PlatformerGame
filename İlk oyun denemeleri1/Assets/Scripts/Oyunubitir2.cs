using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oyunubitir2 : MonoBehaviour
{
    public void oyunubıtır()
    {
        SceneManager.LoadScene(0);
        Score.yildizpuani_int=0;

    }
}
