using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player; //adquire a info do player (a posição neste caso)
    public Vector3 offset; //afastar a camera para nao estar no centro do player
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; //a posição da camera = posição do player

    }
}
