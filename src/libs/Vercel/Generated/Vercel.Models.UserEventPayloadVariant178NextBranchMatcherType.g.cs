
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant178NextBranchMatcherType
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
    public static class UserEventPayloadVariant178NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant178NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant178NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant178NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant178NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant178NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant178NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant178NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant178NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}