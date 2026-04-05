
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseLastAliasRequestType
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
    public static class UpdateMicrofrontendsResponseLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseLastAliasRequestType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseLastAliasRequestType.Promote => "promote",
                UpdateMicrofrontendsResponseLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => UpdateMicrofrontendsResponseLastAliasRequestType.Promote,
                "rollback" => UpdateMicrofrontendsResponseLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}