using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInstructions : MonoBehaviour
{
    public string instructions;

    public void OpenInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
