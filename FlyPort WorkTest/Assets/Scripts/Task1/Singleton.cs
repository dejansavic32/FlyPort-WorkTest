using UnityEngine;
/// <summary>
/// A simple singleton Class.
/// </summary>
public class Singleton
{
    #region singleton
    private static Singleton instance = null;
    private static readonly object threadLock = new object();

    public static Singleton Instance
    {
        get
        {
            lock (threadLock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
    #endregion
    /// <summary>
    /// This method is made public so that any object can access it through the singleton.
    /// </summary>
    public void CallDebugLog()
    {
        Debug.Log("Singleton is being called.");
    }
}
