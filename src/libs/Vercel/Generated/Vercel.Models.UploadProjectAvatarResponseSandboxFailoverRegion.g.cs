
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
        Arn1,
        /// <summary>
        ///
        /// </summary>
        Bom1,
        /// <summary>
        ///
        /// </summary>
        Cdg1,
        /// <summary>
        ///
        /// </summary>
        Cle1,
        /// <summary>
        ///
        /// </summary>
        Cpt1,
        /// <summary>
        ///
        /// </summary>
        Dub1,
        /// <summary>
        ///
        /// </summary>
        Fra1,
        /// <summary>
        ///
        /// </summary>
        Gru1,
        /// <summary>
        ///
        /// </summary>
        Hkg1,
        /// <summary>
        ///
        /// </summary>
        Hnd1,
        /// <summary>
        ///
        /// </summary>
        Iad1,
        /// <summary>
        ///
        /// </summary>
        Icn1,
        /// <summary>
        ///
        /// </summary>
        Kix1,
        /// <summary>
        ///
        /// </summary>
        Lhr1,
        /// <summary>
        ///
        /// </summary>
        Pdx1,
        /// <summary>
        ///
        /// </summary>
        Sfo1,
        /// <summary>
        ///
        /// </summary>
        Sin1,
        /// <summary>
        ///
        /// </summary>
        Syd1,
        /// <summary>
        ///
        /// </summary>
        Yul1,
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
                UploadProjectAvatarResponseSandboxFailoverRegion.Arn1 => "arn1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Bom1 => "bom1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Cdg1 => "cdg1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Cle1 => "cle1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Cpt1 => "cpt1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Dub1 => "dub1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Fra1 => "fra1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Gru1 => "gru1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Hkg1 => "hkg1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Hnd1 => "hnd1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Iad1 => "iad1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Icn1 => "icn1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Kix1 => "kix1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Lhr1 => "lhr1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Pdx1 => "pdx1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Sfo1 => "sfo1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Sin1 => "sin1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Syd1 => "syd1",
                UploadProjectAvatarResponseSandboxFailoverRegion.Yul1 => "yul1",
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
                "arn1" => UploadProjectAvatarResponseSandboxFailoverRegion.Arn1,
                "bom1" => UploadProjectAvatarResponseSandboxFailoverRegion.Bom1,
                "cdg1" => UploadProjectAvatarResponseSandboxFailoverRegion.Cdg1,
                "cle1" => UploadProjectAvatarResponseSandboxFailoverRegion.Cle1,
                "cpt1" => UploadProjectAvatarResponseSandboxFailoverRegion.Cpt1,
                "dub1" => UploadProjectAvatarResponseSandboxFailoverRegion.Dub1,
                "fra1" => UploadProjectAvatarResponseSandboxFailoverRegion.Fra1,
                "gru1" => UploadProjectAvatarResponseSandboxFailoverRegion.Gru1,
                "hkg1" => UploadProjectAvatarResponseSandboxFailoverRegion.Hkg1,
                "hnd1" => UploadProjectAvatarResponseSandboxFailoverRegion.Hnd1,
                "iad1" => UploadProjectAvatarResponseSandboxFailoverRegion.Iad1,
                "icn1" => UploadProjectAvatarResponseSandboxFailoverRegion.Icn1,
                "kix1" => UploadProjectAvatarResponseSandboxFailoverRegion.Kix1,
                "lhr1" => UploadProjectAvatarResponseSandboxFailoverRegion.Lhr1,
                "pdx1" => UploadProjectAvatarResponseSandboxFailoverRegion.Pdx1,
                "sfo1" => UploadProjectAvatarResponseSandboxFailoverRegion.Sfo1,
                "sin1" => UploadProjectAvatarResponseSandboxFailoverRegion.Sin1,
                "syd1" => UploadProjectAvatarResponseSandboxFailoverRegion.Syd1,
                "yul1" => UploadProjectAvatarResponseSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}