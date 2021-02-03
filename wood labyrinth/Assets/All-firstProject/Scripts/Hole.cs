using UnityEngine;

public class Hole : MonoBehaviour
{

    public GameObject ball;

    void Start()
    {
        ball.GetComponent<Transform>();
        //ball.GetComponent<Ball>.transform();
        ball.transform.position += new Vector3(11, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            ball.transform.position = new Vector3(-6, 0.34f, 5.87f);
        }
    }

    void Respawn()
    {
        ball.transform.position = new Vector3(-6, 0.34f, 5.87f);
        
    }

    void Update()
    {
       // Respawn();
        //ball.SetActive(false);
    }
}
