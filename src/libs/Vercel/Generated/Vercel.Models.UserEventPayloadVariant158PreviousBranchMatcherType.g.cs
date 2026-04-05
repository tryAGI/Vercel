
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant158PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant158PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant158PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant158PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant158PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant158PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant158PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant158PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant158PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant158PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}