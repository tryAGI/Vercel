
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseLastAliasRequestType
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
    public static class CreateProjectResponseLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLastAliasRequestType value)
        {
            return value switch
            {
                CreateProjectResponseLastAliasRequestType.Promote => "promote",
                CreateProjectResponseLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => CreateProjectResponseLastAliasRequestType.Promote,
                "rollback" => CreateProjectResponseLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}