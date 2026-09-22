
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6b9922eb6c026513TierRequirement
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6b9922eb6c026513TierRequirementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6b9922eb6c026513TierRequirement value)
        {
            return value switch
            {
                AutoSDKShared6b9922eb6c026513TierRequirement.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6b9922eb6c026513TierRequirement? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKShared6b9922eb6c026513TierRequirement.Priority,
                _ => null,
            };
        }
    }
}