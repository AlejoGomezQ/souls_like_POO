using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    public string play;

    public void OpenSection()
    {
        SceneManager.LoadScene("Level1");
    }
}
