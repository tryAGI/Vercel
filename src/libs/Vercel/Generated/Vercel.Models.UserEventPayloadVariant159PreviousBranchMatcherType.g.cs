
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant159PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant159PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant159PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant159PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant159PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant159PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant159PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant159PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant159PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant159PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}