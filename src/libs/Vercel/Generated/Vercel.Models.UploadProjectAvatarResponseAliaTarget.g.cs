
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseAliaTarget
    {
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
        /// <summary>
        ///
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseAliaTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAliaTarget value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAliaTarget.Preview => "PREVIEW",
                UploadProjectAvatarResponseAliaTarget.Production => "PRODUCTION",
                UploadProjectAvatarResponseAliaTarget.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAliaTarget? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => UploadProjectAvatarResponseAliaTarget.Preview,
                "PRODUCTION" => UploadProjectAvatarResponseAliaTarget.Production,
                "STAGING" => UploadProjectAvatarResponseAliaTarget.Staging,
                _ => null,
            };
        }
    }
}