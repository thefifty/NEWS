﻿namespace Core;

public delegate void AwaitableEventHandler(AwaitableEvent ev);
public delegate void AwaitableEventHandler<TArg>(AwaitableEvent<TArg> ev);
