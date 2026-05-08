using UnityEngine;

public class Enemy2 : MonoBehaviour, IObserver
{

    private void Start()
    {
        GameManager.Instance.Attach(this);
    }

    public void Execute(ISubject subject)
    {
        if (subject is GameManager)
        {
            transform.localScale= Vector3.one * ((GameManager)subject).Progression;
        }
    }

}
