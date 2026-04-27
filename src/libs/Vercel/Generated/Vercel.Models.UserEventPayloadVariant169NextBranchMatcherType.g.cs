
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant169NextBranchMatcherType
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
    public static class UserEventPayloadVariant169NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant169NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant169NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant169NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant169NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant169NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant169NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant169NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant169NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}