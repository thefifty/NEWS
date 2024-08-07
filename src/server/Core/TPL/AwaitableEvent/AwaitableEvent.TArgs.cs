﻿namespace Core;

public class AwaitableEvent<TArgs>
{
    internal Func<TArgs, Task> AsyncHandler;
    public TArgs Args { get; }

    public AwaitableEvent(TArgs args) => Args = args;

    /// <summary>
    /// Invokes an async handler. This should be called only once.
    /// </summary>
    public void Do(Func<Task> work) => Do(x => work());

    /// <summary>
    /// Invokes an async handler. This should be called only once.
    /// </summary>
    public void Do(Func<TArgs, Task> work)
    {
        if (AsyncHandler is null) AsyncHandler = work;
        else throw new("Do() is already called once.");
    }
}