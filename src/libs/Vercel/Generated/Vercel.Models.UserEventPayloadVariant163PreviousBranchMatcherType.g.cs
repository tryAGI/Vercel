
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant163PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant163PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant163PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant163PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant163PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant163PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant163PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant163PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant163PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant163PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}