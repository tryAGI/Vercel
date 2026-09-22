
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3e4933d1b69c5ad0Variant2Status
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
    public static class AutoSDKShared3e4933d1b69c5ad0Variant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3e4933d1b69c5ad0Variant2Status value)
        {
            return value switch
            {
                AutoSDKShared3e4933d1b69c5ad0Variant2Status.Completed => "completed",
                AutoSDKShared3e4933d1b69c5ad0Variant2Status.Queued => "queued",
                AutoSDKShared3e4933d1b69c5ad0Variant2Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3e4933d1b69c5ad0Variant2Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKShared3e4933d1b69c5ad0Variant2Status.Completed,
                "queued" => AutoSDKShared3e4933d1b69c5ad0Variant2Status.Queued,
                "running" => AutoSDKShared3e4933d1b69c5ad0Variant2Status.Running,
                _ => null,
            };
        }
    }
}