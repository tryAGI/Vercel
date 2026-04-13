
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant162NextBranchMatcherType
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
    public static class UserEventPayloadVariant162NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant162NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant162NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant162NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant162NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant162NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant162NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant162NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant162NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}