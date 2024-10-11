using System.Collections;
using UnityEngine;

public class DebugToScreen : MonoBehaviour
{
    string myLog;
    Queue myLogQueue = new Queue();

    public bool mydebug = false;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.BackQuote))
        {
            mydebug = !mydebug;
        }
    }
    void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }

    

    void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        myLog = logString;
        string newString = "\n [" + type + "] : " + myLog;
        myLogQueue.Enqueue(newString);
        if (type == LogType.Exception)
        {
            newString = "\n" + stackTrace;
            myLogQueue.Enqueue(newString);
        }
        myLog = string.Empty;
        foreach (string mylog in myLogQueue)
        {
            myLog += mylog;
        }
    }

    void OnGUI()
    {
        if (mydebug)
            return;
        GUILayout.Label(myLog);
    }
}
