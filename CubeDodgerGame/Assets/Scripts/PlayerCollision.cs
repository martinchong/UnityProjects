using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove move;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Blocks")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
