
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant160NextBranchMatcherType
    {
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        Equals,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant160NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant160NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant160NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant160NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant160NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant160NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant160NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant160NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant160NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}