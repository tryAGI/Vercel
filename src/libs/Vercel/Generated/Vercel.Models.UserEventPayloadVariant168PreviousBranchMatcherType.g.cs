
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant168PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant168PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant168PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant168PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant168PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant168PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant168PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant168PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant168PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant168PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}