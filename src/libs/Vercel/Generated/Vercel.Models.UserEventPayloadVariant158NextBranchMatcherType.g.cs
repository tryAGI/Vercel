
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant158NextBranchMatcherType
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
    public static class UserEventPayloadVariant158NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant158NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant158NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant158NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant158NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant158NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant158NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant158NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant158NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}