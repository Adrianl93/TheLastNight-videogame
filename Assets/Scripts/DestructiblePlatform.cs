using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _timeToBreak = 3f;
    [SerializeField] private float _timeToRespawn = 3f;
    [SerializeField] private GameObject _platformGameObject;

    private float _timeAtCollision;
    private bool _isBreaking;
    private bool _isBroken;

    private void Update()
    {
        if (_isBreaking && !_isBroken)
        {
            if (Time.time >= (_timeAtCollision + _timeToBreak))
            {
                Debug.Log("Plataforma desactivada");
                _platformGameObject.SetActive(false);
                _isBroken = true;
                _timeAtCollision = Time.time; // reinicio conteo para reactivación
            }
        }
        else if (_isBroken)
        {
            if (Time.time >= (_timeAtCollision + _timeToRespawn))
            {
                Debug.Log("Plataforma reactivada");
                _platformGameObject.SetActive(true);
                _isBroken = false;
                _isBreaking = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!_isBreaking && !_isBroken)
        {
            // Confirmamos que haya sido el jugador
            if (collision.gameObject.GetComponent<PlayerInventory>() != null)
            {
                _isBreaking = true;
                _timeAtCollision = Time.time;
                Debug.Log("Colisión detectada - comienza conteo para romper");
            }
        }
    }
}
