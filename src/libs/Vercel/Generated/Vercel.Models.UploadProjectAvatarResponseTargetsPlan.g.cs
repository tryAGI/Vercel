
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseTargetsPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Hobby,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseTargetsPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTargetsPlan value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTargetsPlan.Enterprise => "enterprise",
                UploadProjectAvatarResponseTargetsPlan.Hobby => "hobby",
                UploadProjectAvatarResponseTargetsPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTargetsPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UploadProjectAvatarResponseTargetsPlan.Enterprise,
                "hobby" => UploadProjectAvatarResponseTargetsPlan.Hobby,
                "pro" => UploadProjectAvatarResponseTargetsPlan.Pro,
                _ => null,
            };
        }
    }
}