using UnityEngine;

public class PLayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideforce = 500f;
    

    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideforce*Time.deltaTime,0,0); 
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce((-1*sideforce)*Time.deltaTime,0,0); 
        }
        if(rb.position.y < -1.25f)
        {
            FindObjectOfType<GameManager>().Endgame();

        }

    }
}
