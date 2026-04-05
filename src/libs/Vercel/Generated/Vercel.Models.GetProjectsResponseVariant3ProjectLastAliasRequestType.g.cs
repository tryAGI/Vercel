
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectLastAliasRequestType
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
    public static class GetProjectsResponseVariant3ProjectLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectLastAliasRequestType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectLastAliasRequestType.Promote => "promote",
                GetProjectsResponseVariant3ProjectLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => GetProjectsResponseVariant3ProjectLastAliasRequestType.Promote,
                "rollback" => GetProjectsResponseVariant3ProjectLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}