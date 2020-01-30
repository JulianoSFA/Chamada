using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject entry;
    public GameObject register;
    public GameObject delete;
    public GameObject edit;
    public GameObject view;

    public void LoadScene(GameObject scene)
    {
        CloseAllScenes();
        scene.SetActive(true);
    }

    public void CloseScene(GameObject scene)
    {
        scene.SetActive(false);
    }

    public void CloseAllScenes()
    {
        entry.SetActive(false);
        register.SetActive(false);
        delete.SetActive(false);
        edit.SetActive(false);
        view.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
