
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared12773eaec07789a9Status
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared12773eaec07789a9StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared12773eaec07789a9Status value)
        {
            return value switch
            {
                AutoSDKShared12773eaec07789a9Status.Completed => "completed",
                AutoSDKShared12773eaec07789a9Status.Queued => "queued",
                AutoSDKShared12773eaec07789a9Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared12773eaec07789a9Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKShared12773eaec07789a9Status.Completed,
                "queued" => AutoSDKShared12773eaec07789a9Status.Queued,
                "running" => AutoSDKShared12773eaec07789a9Status.Running,
                _ => null,
            };
        }
    }
}