
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UserEventPayloadVariant163NextBranchMatcherType
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
    public static class UserEventPayloadVariant163NextBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant163NextBranchMatcherType value)
        {
            return value switch
            {
                UserEventPayloadVariant163NextBranchMatcherType.EndsWith => "endsWith",
                UserEventPayloadVariant163NextBranchMatcherType.Equals => "equals",
                UserEventPayloadVariant163NextBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant163NextBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UserEventPayloadVariant163NextBranchMatcherType.EndsWith,
                "equals" => UserEventPayloadVariant163NextBranchMatcherType.Equals,
                "startsWith" => UserEventPayloadVariant163NextBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}