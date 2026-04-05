
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseLastAliasRequestType
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
    public static class UpdateProjectResponseLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLastAliasRequestType value)
        {
            return value switch
            {
                UpdateProjectResponseLastAliasRequestType.Promote => "promote",
                UpdateProjectResponseLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => UpdateProjectResponseLastAliasRequestType.Promote,
                "rollback" => UpdateProjectResponseLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}