
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant169PreviousBranchMatcherType
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
    public static class UserEventPayloadVariant169PreviousBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant169PreviousBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant169PreviousBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant169PreviousBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant169PreviousBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant169PreviousBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant169PreviousBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant169PreviousBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant169PreviousBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}