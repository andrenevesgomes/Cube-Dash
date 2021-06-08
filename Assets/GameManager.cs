
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameIsOver = false;
    public float delayRestart = 1f;
    public void GameOver()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true;
            //Restart Game. Usa-se o Invoke para colocar um delay
            Invoke("Restart", delayRestart);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //vai dar reload na cena atual. O código dentro dos parentesis vai buscar o nome da cena em que o jogador se encontra.
    }
}
