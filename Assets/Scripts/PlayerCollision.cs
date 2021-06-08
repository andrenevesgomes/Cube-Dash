
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player movement; //referencia ao script que move o jogador
    public GameManager gameManager; //referencia ao GameManager
    void OnCollisionEnter(Collision info) //Collider com os objectos que tem RigidBody
    {
        if (info.collider.tag == "Obstacle") //se o player colidir com um objecto com a tag "Obstacle" o movimento para
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}
