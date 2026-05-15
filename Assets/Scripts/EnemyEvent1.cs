using UnityEngine;

public class EnemyEvent1 : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameEventManager.Instance.OnProgressionChanged += OnProgressionChanged;
    }

    public void OnProgressionChanged(int progression)
    {
        speed = progression;
    }

    private void Update()
    {
        rb.linearVelocity = Vector3.forward * speed;
    }
}
