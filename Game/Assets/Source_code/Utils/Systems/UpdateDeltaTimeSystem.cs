﻿using UnityEngine;
using Entitas;

/// <summary>
/// Логика обновления клока относительно Time.deltaTime
/// </summary>
public class UpdateDeltaTimeSystem : IExecuteSystem
{
    private Contexts _contexts;

    public UpdateDeltaTimeSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        _contexts.global.ReplaceDeltaTime(Time.deltaTime);
    }
}
