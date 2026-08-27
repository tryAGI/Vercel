
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseCreatorVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseCreatorVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseCreatorVariant2Type value)
        {
            return value switch
            {
                UploadProjectAvatarResponseCreatorVariant2Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseCreatorVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => UploadProjectAvatarResponseCreatorVariant2Type.App,
                _ => null,
            };
        }
    }
}