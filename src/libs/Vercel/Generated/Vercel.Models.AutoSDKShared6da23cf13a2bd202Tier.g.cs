
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6da23cf13a2bd202Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6da23cf13a2bd202TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6da23cf13a2bd202Tier value)
        {
            return value switch
            {
                AutoSDKShared6da23cf13a2bd202Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6da23cf13a2bd202Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKShared6da23cf13a2bd202Tier.Priority,
                _ => null,
            };
        }
    }
}