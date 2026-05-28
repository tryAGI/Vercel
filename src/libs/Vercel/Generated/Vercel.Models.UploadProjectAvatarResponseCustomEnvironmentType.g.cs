
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum UploadProjectAvatarResponseCustomEnvironmentType
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseCustomEnvironmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseCustomEnvironmentType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseCustomEnvironmentType.Development => "development",
                UploadProjectAvatarResponseCustomEnvironmentType.Preview => "preview",
                UploadProjectAvatarResponseCustomEnvironmentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseCustomEnvironmentType? ToEnum(string value)
        {
            return value switch
            {
                "development" => UploadProjectAvatarResponseCustomEnvironmentType.Development,
                "preview" => UploadProjectAvatarResponseCustomEnvironmentType.Preview,
                "production" => UploadProjectAvatarResponseCustomEnvironmentType.Production,
                _ => null,
            };
        }
    }
}