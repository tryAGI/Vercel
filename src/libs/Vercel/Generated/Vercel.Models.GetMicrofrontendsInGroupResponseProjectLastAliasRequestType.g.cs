
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLastAliasRequestType
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
    public static class GetMicrofrontendsInGroupResponseProjectLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLastAliasRequestType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLastAliasRequestType.Promote => "promote",
                GetMicrofrontendsInGroupResponseProjectLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => GetMicrofrontendsInGroupResponseProjectLastAliasRequestType.Promote,
                "rollback" => GetMicrofrontendsInGroupResponseProjectLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}