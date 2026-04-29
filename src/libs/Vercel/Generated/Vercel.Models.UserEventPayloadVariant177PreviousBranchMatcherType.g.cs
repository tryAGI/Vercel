
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant177PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant177PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant177PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant177PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant177PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant177PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant177PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant177PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant177PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant177PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}