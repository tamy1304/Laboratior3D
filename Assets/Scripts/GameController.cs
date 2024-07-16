using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{


    public void EscenaJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void EscenaInicio()
    {
        SceneManager.LoadScene("Menu");
    }

    public void EscenaLogin()
    {
        SceneManager.LoadScene("SampleScene1");
    }


}
