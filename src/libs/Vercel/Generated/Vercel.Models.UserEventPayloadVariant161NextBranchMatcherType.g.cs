
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant161NextBranchMatcherType
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
    public static class UserEventPayloadVariant161NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant161NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant161NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant161NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant161NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant161NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant161NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant161NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant161NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}