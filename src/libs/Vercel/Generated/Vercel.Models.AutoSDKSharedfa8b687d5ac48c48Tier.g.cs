
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa8b687d5ac48c48Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfa8b687d5ac48c48TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa8b687d5ac48c48Tier value)
        {
            return value switch
            {
                AutoSDKSharedfa8b687d5ac48c48Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa8b687d5ac48c48Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKSharedfa8b687d5ac48c48Tier.Priority,
                _ => null,
            };
        }
    }
}