
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant177NextBranchMatcherType
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
    public static class UserEventPayloadVariant177NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant177NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant177NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant177NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant177NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant177NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant177NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant177NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant177NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}