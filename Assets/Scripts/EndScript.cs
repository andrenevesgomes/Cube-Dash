
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter() {
        gameManager.NivelCompleto();
    }
}
