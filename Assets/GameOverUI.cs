using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel;   // Panel ����բ�ͤ��� "Game Over"
    public Text gameOverText;          // (optional) ��ҵ�ͧ������ͤ���
    public bool pauseTimeOnGameOver = true;

    void Start()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    public void ShowGameOver()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        if (pauseTimeOnGameOver)
            Time.timeScale = 0f;
    }

    // ��ҵ�ͧ��� ����ͻ��� Restart � UI ���¡���ʹ���
    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // ���� Quit (��� editor ����ش playmode)
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

