
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant168NextBranchMatcherType
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
    public static class UserEventPayloadVariant168NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant168NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant168NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant168NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant168NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant168NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant168NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant168NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant168NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}