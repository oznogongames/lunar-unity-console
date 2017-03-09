﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using LunarConsolePlugin;

public class APIScene : MonoBehaviour
{
    void Start()
    {
        LunarConsole.onConsoleOpened += OnConsoleOpened;
        LunarConsole.onConsoleClosed += OnConsoleClosed;

        LunarConsole.RegisterAction("Disabled Console", DisableConsole);
    }

    void OnDestroy()
    {
        LunarConsole.onConsoleOpened -= OnConsoleOpened;
        LunarConsole.onConsoleClosed -= OnConsoleClosed;

        LunarConsole.UnregisterAction(DisableConsole);
    }

    public void OpenConsole()
    {
        LunarConsole.Show();
    }

    public void CloseConsole()
    {
        LunarConsole.Hide();
    }

    public void ClearConsole()
    {
        LunarConsole.Clear();
    }

    public void EnableConsole()
    {
        LunarConsole.SetConsoleEnabled(true);
    }

    public void DisableConsole()
    {
        LunarConsole.SetConsoleEnabled(false);
    }

    private void OnConsoleOpened()
    {
        Debug.Log("Console open");
    }

    private void OnConsoleClosed()
    {
        Debug.Log("Console close");
    }
}
