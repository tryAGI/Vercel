
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseLastAliasRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Promote,
        /// <summary>
        /// 
        /// </summary>
        Rollback,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLastAliasRequestType value)
        {
            return value switch
            {
                GetProjectResponseLastAliasRequestType.Promote => "promote",
                GetProjectResponseLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => GetProjectResponseLastAliasRequestType.Promote,
                "rollback" => GetProjectResponseLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}