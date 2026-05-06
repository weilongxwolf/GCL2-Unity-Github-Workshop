using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player hurt");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
