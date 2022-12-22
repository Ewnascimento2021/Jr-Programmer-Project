using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToMenuCanvas : MonoBehaviour
{
    [SerializeField]
    private Button returnToMenu;

    private void Awake()
    {
        returnToMenu.onClick.AddListener(ReturnToMenu);

    }
    
         private void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
