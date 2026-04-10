
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant161PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant161PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant161PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant161PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant161PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant161PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant161PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant161PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant161PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant161PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}