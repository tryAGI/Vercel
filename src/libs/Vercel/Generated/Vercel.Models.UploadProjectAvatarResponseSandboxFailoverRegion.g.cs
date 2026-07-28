
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseSandboxFailoverRegion
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
    public static class UploadProjectAvatarResponseSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSandboxFailoverRegion value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSandboxFailoverRegion.Cle1 => "cle1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Iad1 => "iad1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cle1" => UploadProjectAvatarResponseSandboxFailoverRegion.Cle1,
                "iad1" => UploadProjectAvatarResponseSandboxFailoverRegion.Iad1,
                "sfo1" => UploadProjectAvatarResponseSandboxFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}