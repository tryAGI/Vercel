
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseCreatorVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseCreatorVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseCreatorVariant4Type value)
        {
            return value switch
            {
                UploadProjectAvatarResponseCreatorVariant4Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseCreatorVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UploadProjectAvatarResponseCreatorVariant4Type.System,
                _ => null,
            };
        }
    }
}