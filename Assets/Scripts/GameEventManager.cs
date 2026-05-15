using UnityEngine;
using System;

public class GameEventManager : MonoBehaviour
{
    private static GameEventManager instance;

    public static GameEventManager Instance { get { return instance; } }

    public event Action<int> OnProgressionChanged;

    private int progression;
    private float timer;

    public int Progression { get { return progression; } }

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > progression)
        {
            progression++;
            OnProgressionChanged?.Invoke(progression);
        }
    }
}
