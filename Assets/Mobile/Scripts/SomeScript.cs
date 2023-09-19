using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyLogHandler : ILogHandler
{
    public void LogException(Exception exception, UnityEngine.Object context)
    {
        Debug.unityLogger.LogException(exception, context);
    }

    public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
    {//editing code while compulation is in progress
        Debug.unityLogger.logHandler.LogFormat(logType, context, format, args);
    }
}

public class MyGameClass : MonoBehaviour
{
    private static string kTAG = "MyGameTag";
    private Logger myLogger;

    void Start()
    {
        myLogger = new Logger(new MyLogHandler());

        myLogger.Log(kTAG, "MyGameClass Start.");
    }
}
