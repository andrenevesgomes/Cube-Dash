
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool gameIsOver = false; //variavel para verificar se o jogo terminou
    public float delayRestart = 1f; //variável para nao terminar fechar imediatamente a cena. Fica com um atraso de 1seg.

    public GameObject nivelCompleto;

    public void NivelCompleto()
    {
        nivelCompleto.SetActive(true);
    }

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
