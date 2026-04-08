
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant159NextBranchMatcherType
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
    public static class UserEventPayloadVariant159NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant159NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant159NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant159NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant159NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant159NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant159NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant159NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant159NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}