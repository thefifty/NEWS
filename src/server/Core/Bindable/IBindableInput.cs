﻿namespace Core;

public interface IBindableInput
{
    event InputChanged InputChanged;
}

public delegate void InputChanged(string property);
