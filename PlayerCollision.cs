using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PLayerMovement movement;
    void OnCollisionEnter(Collision cinfo)
    {
        if(cinfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();    

        }

    }
}
