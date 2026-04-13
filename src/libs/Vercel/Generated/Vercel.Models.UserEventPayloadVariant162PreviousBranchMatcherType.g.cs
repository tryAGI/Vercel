
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant162PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant162PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant162PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant162PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant162PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant162PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant162PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant162PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant162PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant162PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}