
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseSandboxRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Cle1,
        /// <summary>
        /// 
        /// </summary>
        Iad1,
        /// <summary>
        /// 
        /// </summary>
        Sfo1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSandboxRegion value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSandboxRegion.Cle1 => "cle1",
                UploadProjectAvatarResponseSandboxRegion.Iad1 => "iad1",
                UploadProjectAvatarResponseSandboxRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "cle1" => UploadProjectAvatarResponseSandboxRegion.Cle1,
                "iad1" => UploadProjectAvatarResponseSandboxRegion.Iad1,
                "sfo1" => UploadProjectAvatarResponseSandboxRegion.Sfo1,
                _ => null,
            };
        }
    }
}