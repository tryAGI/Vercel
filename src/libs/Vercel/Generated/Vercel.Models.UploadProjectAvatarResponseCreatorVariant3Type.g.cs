
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseCreatorVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseCreatorVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseCreatorVariant3Type value)
        {
            return value switch
            {
                UploadProjectAvatarResponseCreatorVariant3Type.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseCreatorVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "integration" => UploadProjectAvatarResponseCreatorVariant3Type.Integration,
                _ => null,
            };
        }
    }
}