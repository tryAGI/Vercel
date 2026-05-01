
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant178PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant178PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant178PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant178PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant178PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant178PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant178PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant178PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant178PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant178PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}