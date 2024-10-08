﻿using System.ComponentModel;

namespace Core;

[EditorBrowsable(EditorBrowsableState.Never)]
public static partial class XExtensions
{
    const int MAXIMUM_ATTEMPTS = 3;
    const int ATTEMPT_PAUSE = 50 /*Milisseconds*/;

    static Task<T> TryHardAsync<T>(FileSystemInfo fileOrFolder, Func<Task<T>> func, string error)
    {
        var resultTask = new TaskCompletionSource<T>();
        DoTryHardAsync(fileOrFolder, async () => resultTask.TrySetResult(await func().ConfigureAwait(false)), error)
            .GetAwaiter();
        return resultTask.Task;
    }

    static async Task DoTryHardAsync(FileSystemInfo fileOrFolder, Func<Task> func, string error)
    {
        var attempt = 0;

        Exception problem = null;

        while (attempt <= MAXIMUM_ATTEMPTS)
        {
            try
            {
                if (func != null) await func().ConfigureAwait(false);
                return;
            }
            catch (Exception ex)
            {
                problem = ex;

                // Remove attributes:
                try
                {
                    fileOrFolder.Attributes = FileAttributes.Normal;
                }
                catch
                {
                    // No logging needed
                }

                attempt++;

                // Pause for a short amount of time (to allow a potential external process to leave the file/directory).
                await Task.Delay(ATTEMPT_PAUSE).ConfigureAwait(false);
            }
        }

        throw new IOException(error.FormatWith(fileOrFolder.FullName), problem);
    }

    static T TryHard<T>(FileSystemInfo fileOrFolder, Func<T> action, string error)
    {
        var result = default(T);
        DoTryHard(fileOrFolder, () => result = action(), error);
        return result;
    }

    static void DoTryHard(FileSystemInfo fileOrFolder, Action action, string error)
    {
        var attempt = 0;

        Exception problem = null;

        while (attempt <= MAXIMUM_ATTEMPTS)
        {
            try
            {
                action?.Invoke();
                return;
            }
            catch (Exception ex)
            {
                problem = ex;

                // Remove attributes:
                try
                {
                    fileOrFolder.Attributes = FileAttributes.Normal;
                }
                catch
                {
                    // No logging is needed
                }

                attempt++;

                // Pause for a short amount of time (to allow a potential external process to leave the file/directory).
                System.Threading.Thread.Sleep(ATTEMPT_PAUSE);
            }
        }

        throw new IOException(error.FormatWith(fileOrFolder.FullName), problem);
    }

    /// <summary>
    /// Returns a nullable value wrapper object if this value is the default for its type.
    /// </summary>
    public static T? NullIfDefault<T>(this T @value, T defaultValue = default) where T : struct
    {
        if (value.Equals(defaultValue)) return null;
        return @value;
    }
}