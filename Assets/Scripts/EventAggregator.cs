using System;

public static class EventAggregator
{
    public static event Action GameStart;
    public static event Action<bool> GameOver; 

    public static void OnGameStart()
    {
        GameStart?.Invoke();
    }
    public static void OnGameOver(bool obj)
    {
        GameOver?.Invoke(obj);
    }
}
