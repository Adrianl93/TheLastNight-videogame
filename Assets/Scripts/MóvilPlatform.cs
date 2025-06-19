using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("Movimiento de Plataforma")]
    [SerializeField] private Vector2 direction = Vector2.right;
    [SerializeField] private float distance = 3f;
    [SerializeField] private float speed = 2f;

    private Vector3 _startPos;
    private bool _movingForward = true;

    private void Start()
    {
        _startPos = transform.position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 moveDir = new Vector3(direction.x, direction.y, 0).normalized;

        if (_movingForward)
        {
            transform.position += moveDir * speed * Time.deltaTime;

            if (Vector3.Distance(_startPos, transform.position) >= distance)
                _movingForward = false;
        }
        else
        {
            transform.position -= moveDir * speed * Time.deltaTime;

            if (Vector3.Distance(_startPos, transform.position) <= 0.1f)
                _movingForward = true;
        }
    }
}
