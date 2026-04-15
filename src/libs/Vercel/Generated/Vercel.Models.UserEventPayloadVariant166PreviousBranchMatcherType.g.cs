
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant166PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant166PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant166PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant166PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant166PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant166PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant166PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant166PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant166PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant166PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}