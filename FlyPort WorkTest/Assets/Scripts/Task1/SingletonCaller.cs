using UnityEngine;
/// <summary>
/// A simple class that prints a message through the activation of the Singleton Class.
/// </summary>
public class SingletonCaller : MonoBehaviour
{
    [SerializeField]
    private KeyCode keyCode = KeyCode.Space;

    private void Update()
    {
        LogOnKeyPress(keyCode);
    }

    private void LogOnKeyPress(KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode))
        {
            Singleton.Instance.CallDebugLog();
        }
    }
}
