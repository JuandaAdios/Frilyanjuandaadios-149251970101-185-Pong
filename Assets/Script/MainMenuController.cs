using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private Rigidbody2D rig;

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void CreditTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Frilyan Juanda Adios - 149251970101-185");
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }
}
