
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant160PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant160PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant160PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant160PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant160PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant160PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant160PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant160PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant160PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant160PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}