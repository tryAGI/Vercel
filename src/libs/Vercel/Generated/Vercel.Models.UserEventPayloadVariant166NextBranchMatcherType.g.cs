
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant166NextBranchMatcherType
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
    public static class UserEventPayloadVariant166NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant166NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant166NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant166NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant166NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant166NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant166NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant166NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant166NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}