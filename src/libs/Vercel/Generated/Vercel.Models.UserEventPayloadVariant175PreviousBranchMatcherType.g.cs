
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant175PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant175PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant175PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant175PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant175PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant175PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant175PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant175PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant175PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant175PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}