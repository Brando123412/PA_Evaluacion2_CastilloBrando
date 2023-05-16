using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    public Button btnPlay;
    Vector3 mouseInput;
    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(() => Play());
    }

    void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnAim(InputAction.CallbackContext value)
    {
        Vector2 inputMouse = Camera.main.ScreenToWorldPoint(value.ReadValue<Vector2>());
        mouseInput = inputMouse;
    }

}
