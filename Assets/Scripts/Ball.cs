using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    public float speed = 10f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector2.zero;
        _rigidbody.linearVelocity = Vector2.zero;


    }

    public void AddStartingForce()
    {
        Debug.Log("AddStartingForce called!");

        // Randomly choose a direction (x = left/right, y = up/down)
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

        // Normalize and multiply by speed
        Vector2 direction = new Vector2(x, y).normalized;
        _rigidbody.linearVelocity = direction * speed;

        Debug.Log("Velocity set to: " + _rigidbody.linearVelocity);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }
}
