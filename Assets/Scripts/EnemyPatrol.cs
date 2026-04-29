using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject posL;
    public GameObject posR;
    private Rigidbody2D rb;
    private Transform currentPos;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPos = posR.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPos.position - transform.position;
        if (currentPos == posR.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPos.position) < 0.5f && currentPos == posR.transform)
        {
            currentPos = posL.transform;
        }
        if (Vector2.Distance(transform.position, currentPos.position) < 0.5f && currentPos == posL.transform)
        {
            currentPos = posR.transform;
        }
    }
}
