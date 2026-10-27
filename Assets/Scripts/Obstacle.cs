using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float MIN_SIZE = 0.5f;
    public float MAX_SIZE = 2.0f;
    public float MIN_SPEED = 100f;
    public float MAX_SPEED = 300f;
    public float MAX_SPIN_SPEED = 10f;

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(MIN_SIZE, MAX_SIZE);
        transform.localScale = new Vector3(randomSize, randomSize, 1);

        rb = GetComponent<Rigidbody2D>();
        float randomSpeed = Random.Range(MIN_SPEED, MAX_SPEED) / randomSize;
        Vector2 randomDirection = Random.insideUnitCircle;
        rb.AddForce(randomDirection * randomSpeed);

        float randomTorque = Random.Range(-MAX_SPIN_SPEED, MAX_SPIN_SPEED);
        rb.AddTorque(randomTorque);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
