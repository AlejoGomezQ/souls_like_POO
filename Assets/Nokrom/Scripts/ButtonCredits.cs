using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCredits : MonoBehaviour
{
    public string credits;

    public void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
