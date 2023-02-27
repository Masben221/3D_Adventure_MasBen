using SimpleFPS;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    private FirstPersonController _fpc;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        _fpc = GetComponent<FirstPersonController>();
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                if (_pauseMenu.activeSelf)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
        }
    }
    public void Resume()
    {
        _pauseMenu.SetActive(false);
        //Time.timeScale = 1f;
        if (_fpc != null)
        {
            _fpc.enabled = true;
        }        
    }

    public void Pause()
    {
        _pauseMenu.SetActive(true);
        //Time.timeScale = 0f;
        if (_fpc != null)
        {
            _fpc.enabled = false;
        }
    }

    public void RestartLevel()
    {
        //Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadLevel(int _buildIndex)
    {
        //Time.timeScale = 1f;
        SceneManager.LoadScene(_buildIndex);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
