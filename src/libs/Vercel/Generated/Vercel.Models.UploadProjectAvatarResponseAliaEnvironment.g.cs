
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseAliaEnvironment
    {
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
    public static class UploadProjectAvatarResponseAliaEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAliaEnvironment value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAliaEnvironment.Preview => "preview",
                UploadProjectAvatarResponseAliaEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAliaEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UploadProjectAvatarResponseAliaEnvironment.Preview,
                "production" => UploadProjectAvatarResponseAliaEnvironment.Production,
                _ => null,
            };
        }
    }
}