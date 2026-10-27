
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfc5823c22a1eaa2bTier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfc5823c22a1eaa2bTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfc5823c22a1eaa2bTier value)
        {
            return value switch
            {
                AutoSDKSharedfc5823c22a1eaa2bTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfc5823c22a1eaa2bTier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKSharedfc5823c22a1eaa2bTier.Priority,
                _ => null,
            };
        }
    }
}