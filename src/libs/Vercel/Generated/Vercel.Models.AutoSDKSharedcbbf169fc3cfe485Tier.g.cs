
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcbbf169fc3cfe485Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedcbbf169fc3cfe485TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcbbf169fc3cfe485Tier value)
        {
            return value switch
            {
                AutoSDKSharedcbbf169fc3cfe485Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcbbf169fc3cfe485Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKSharedcbbf169fc3cfe485Tier.Priority,
                _ => null,
            };
        }
    }
}