
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant175NextBranchMatcherType
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
    public static class UserEventPayloadVariant175NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant175NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant175NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant175NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant175NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant175NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant175NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant175NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant175NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}