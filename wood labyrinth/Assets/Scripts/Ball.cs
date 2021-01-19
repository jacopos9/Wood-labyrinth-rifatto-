using UnityEngine;

public class Ball : MonoBehaviour
{

    public Vector3 direction;
    public float velocity;
    Rigidbody rb;
    public Vector3 startPos; //posizione iniziale


    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // startPos = new Vector3(-6, 0.34f, 5.87f);
        //transform.position = startPos;
    }

    void Respawn()
    {
        transform.position = new Vector3(-6, 0.34f, 5.87f);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Hole")
        {
            //transform.position = new Vector3(-6, 0.34f, 5.87f);
            Respawn();
        }
    }


    void BallMovement()
    {
        direction.x = Input.acceleration.x;
        direction.y = Input.acceleration.y;

        rb.AddForce(new Vector3(direction.x, 0f, direction.y) * velocity * Time.deltaTime);
    }

    void PcInputSystem()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, v) * 3f * Time.deltaTime);
    }

    void Update()
    {
        BallMovement();
       // PcInputSystem();
    }
}