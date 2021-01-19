using UnityEngine;

public class VictoryHole : MonoBehaviour
{


    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("vittoria");
        }
    }

    void Update()
    {

    }
}
