
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd474136b05e5e447TierRequirement
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd474136b05e5e447TierRequirementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd474136b05e5e447TierRequirement value)
        {
            return value switch
            {
                AutoSDKSharedd474136b05e5e447TierRequirement.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd474136b05e5e447TierRequirement? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKSharedd474136b05e5e447TierRequirement.Priority,
                _ => null,
            };
        }
    }
}