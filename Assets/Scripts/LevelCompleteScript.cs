
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteScript : MonoBehaviour
{
    public void LoadNextLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Para ler a proxima cena. Recebe a cena atual em que está e depois o +1 serve para ir para o proximo index de cenas
    }
}
