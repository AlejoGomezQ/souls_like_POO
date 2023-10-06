using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackHome : MonoBehaviour
{
    public string home;

    public void GoToHome()
    {
        SceneManager.LoadScene("Home");
    }
}
