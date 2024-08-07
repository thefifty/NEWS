﻿using System.Runtime.CompilerServices;

namespace Core;

public static partial class GuardClauseExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static int Zero(this IGuardClause guardClause,
        int input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null,
        Exception exception = null)
    {
        return Zero<int>(guardClause, input, parameterName!, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static long Zero(this IGuardClause guardClause,
        long input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null,
        Exception exception = null)
    {
        return Zero<long>(guardClause, input, parameterName!, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static decimal Zero(this IGuardClause guardClause,
        decimal input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null,
        Exception exception = null)
    {
        return Zero<decimal>(guardClause, input, parameterName!, message,exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static float Zero(this IGuardClause guardClause,
        float input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null,
        Exception exception = null)
    {
        return Zero<float>(guardClause, input, parameterName!, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static double Zero(this IGuardClause guardClause,
        double input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null,
        Exception exception = null)
    {
        return Zero<double>(guardClause, input, parameterName!, message,exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static TimeSpan Zero(this IGuardClause guardClause,
        TimeSpan input,
        [CallerArgumentExpression("input")] string parameterName = null,
        Exception exception = null)
    {
        return Zero<TimeSpan>(guardClause, input, parameterName!, exception:exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    private static T Zero<T>(this IGuardClause guardClause, T input, string parameterName, string message = null,
        Exception exception = null) where T : struct
    {
        if (EqualityComparer<T>.Default.Equals(input, default(T)))
        {
            throw exception ?? new ArgumentException(message ?? $"Required input {parameterName} cannot be zero.", parameterName);
        }

        return input;
    }
}
