﻿using System.Runtime.CompilerServices;

namespace Core;

public static partial class GuardClauseExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static int Negative(this IGuardClause guardClause,
        int input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null,
        Exception exception = null)
    {
        return Negative<int>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static long Negative(this IGuardClause guardClause,
        long input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null,
        Exception exception = null)
    {
        return Negative<long>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative.</returns>
    /// <exception cref="Exception"></exception>
    public static decimal Negative(this IGuardClause guardClause,
        decimal input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, 
        Exception exception = null)
    {
        return Negative<decimal>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative.</returns>
    /// <exception cref="Exception"></exception>
    public static float Negative(this IGuardClause guardClause,
        float input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, Exception exception = null)
    {
        return Negative<float>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative.</returns>
    /// <exception cref="Exception"></exception>
    public static double Negative(this IGuardClause guardClause,
        double input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, Exception exception = null)
    {
        return Negative<double>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative.</returns>
    /// <exception cref="Exception"></exception>
    public static TimeSpan Negative(this IGuardClause guardClause,
        TimeSpan input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, Exception exception = null)
    {
        return Negative<TimeSpan>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException" /> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    private static T Negative<T>(this IGuardClause guardClause,
        T input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, Exception exception = null) where T : struct, IComparable
    {
        if (input.CompareTo(default(T)) < 0)
        {
            throw exception ?? new ArgumentException(message ?? $"Required input {parameterName} cannot be negative.", parameterName!);
        }

        return input;
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static int NegativeOrZero(this IGuardClause guardClause,
        int input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, Exception exception = null)
    {
        return NegativeOrZero<int>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static long NegativeOrZero(this IGuardClause guardClause,
        long input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, Exception exception = null)
    {
        return NegativeOrZero<long>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static decimal NegativeOrZero(this IGuardClause guardClause,
        decimal input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, Exception exception = null)
    {
        return NegativeOrZero<decimal>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static float NegativeOrZero(this IGuardClause guardClause,
        float input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, Exception exception = null)
    {
        return NegativeOrZero<float>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static double NegativeOrZero(this IGuardClause guardClause,
        double input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, Exception exception = null)
    {
        return NegativeOrZero<double>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative or zero.
    /// </summary>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    public static TimeSpan NegativeOrZero(this IGuardClause guardClause,
        TimeSpan input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, Exception exception = null)
    {
        return NegativeOrZero<TimeSpan>(guardClause, input, parameterName, message, exception);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> or a custom <see cref="Exception" /> if <paramref name="input"/> is negative or zero. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guardClause"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <param name="exception"></param>
    /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="Exception"></exception>
    private static T NegativeOrZero<T>(this IGuardClause guardClause,
        T input,
        [CallerArgumentExpression("input")] string parameterName = null,
        string message = null, 
        Exception exception = null) where T : struct, IComparable
    {
        if (input.CompareTo(default(T)) <= 0)
        {
            throw exception ?? new ArgumentException(message ?? $"Required input {parameterName} cannot be zero or negative.", parameterName!);
        }

        return input;
    }
}
