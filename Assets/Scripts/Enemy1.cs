using UnityEngine;

public class Enemy1 : MonoBehaviour, IObserver
{
    private Rigidbody rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameManager.Instance.Attach(this);
    }

    public void Execute(ISubject subject)
    {
        if(subject is GameManager)
        {
            speed=((GameManager)subject).Progression;
        }
    }

    private void Update()
    {
        rb.linearVelocity = Vector3.forward * speed;
    }
}
