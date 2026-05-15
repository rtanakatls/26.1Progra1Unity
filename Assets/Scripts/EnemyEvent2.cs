using UnityEngine;

public class EnemyEvent2 : MonoBehaviour
{

    private void Start()
    {
        GameEventManager.Instance.OnProgressionChanged += OnProgressionChanged;
    }

    public void OnProgressionChanged(int progression)
    {
        transform.localScale=Vector3.one*progression;
    }

}
