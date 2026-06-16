
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseLastAliasRequestType
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
    public static class UploadProjectAvatarResponseLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseLastAliasRequestType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseLastAliasRequestType.Promote => "promote",
                UploadProjectAvatarResponseLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => UploadProjectAvatarResponseLastAliasRequestType.Promote,
                "rollback" => UploadProjectAvatarResponseLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}