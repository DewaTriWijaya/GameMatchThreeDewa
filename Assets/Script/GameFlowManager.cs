using UnityEngine;

public class GameFlowManager : MonoBehaviour
{
    #region Singleton

    private static GameFlowManager _instance = null;

    public static GameFlowManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameFlowManager>();

                if(_instance == null)
                {
                    Debug.LogError("Fata Error: GameFlowManager not found");
                }
            }
            return _instance;
        }
    }

    #endregion

    [Header("UI")]
    public UIGameOver GameOverUI;

    public bool IsGamerOver { get { return isGamerOver; } }

    private bool isGamerOver = false;

    private void Start()
    {

        isGamerOver = false;
    }


    public void GameOver()
    {
        isGamerOver = true;
        ScoreManager.Instance.setHighScore();
        GameOverUI.Show();
    }
}
