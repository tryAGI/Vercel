
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
    public static class UploadProjectAvatarResponseSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSandboxRegion value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSandboxRegion.Arn1 => "arn1",
                UploadProjectAvatarResponseSandboxRegion.Bom1 => "bom1",
                UploadProjectAvatarResponseSandboxRegion.Cdg1 => "cdg1",
                UploadProjectAvatarResponseSandboxRegion.Cle1 => "cle1",
                UploadProjectAvatarResponseSandboxRegion.Cpt1 => "cpt1",
                UploadProjectAvatarResponseSandboxRegion.Dub1 => "dub1",
                UploadProjectAvatarResponseSandboxRegion.Fra1 => "fra1",
                UploadProjectAvatarResponseSandboxRegion.Gru1 => "gru1",
                UploadProjectAvatarResponseSandboxRegion.Hkg1 => "hkg1",
                UploadProjectAvatarResponseSandboxRegion.Hnd1 => "hnd1",
                UploadProjectAvatarResponseSandboxRegion.Iad1 => "iad1",
                UploadProjectAvatarResponseSandboxRegion.Icn1 => "icn1",
                UploadProjectAvatarResponseSandboxRegion.Kix1 => "kix1",
                UploadProjectAvatarResponseSandboxRegion.Lhr1 => "lhr1",
                UploadProjectAvatarResponseSandboxRegion.Pdx1 => "pdx1",
                UploadProjectAvatarResponseSandboxRegion.Sfo1 => "sfo1",
                UploadProjectAvatarResponseSandboxRegion.Sin1 => "sin1",
                UploadProjectAvatarResponseSandboxRegion.Syd1 => "syd1",
                UploadProjectAvatarResponseSandboxRegion.Yul1 => "yul1",
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
                "arn1" => UploadProjectAvatarResponseSandboxRegion.Arn1,
                "bom1" => UploadProjectAvatarResponseSandboxRegion.Bom1,
                "cdg1" => UploadProjectAvatarResponseSandboxRegion.Cdg1,
                "cle1" => UploadProjectAvatarResponseSandboxRegion.Cle1,
                "cpt1" => UploadProjectAvatarResponseSandboxRegion.Cpt1,
                "dub1" => UploadProjectAvatarResponseSandboxRegion.Dub1,
                "fra1" => UploadProjectAvatarResponseSandboxRegion.Fra1,
                "gru1" => UploadProjectAvatarResponseSandboxRegion.Gru1,
                "hkg1" => UploadProjectAvatarResponseSandboxRegion.Hkg1,
                "hnd1" => UploadProjectAvatarResponseSandboxRegion.Hnd1,
                "iad1" => UploadProjectAvatarResponseSandboxRegion.Iad1,
                "icn1" => UploadProjectAvatarResponseSandboxRegion.Icn1,
                "kix1" => UploadProjectAvatarResponseSandboxRegion.Kix1,
                "lhr1" => UploadProjectAvatarResponseSandboxRegion.Lhr1,
                "pdx1" => UploadProjectAvatarResponseSandboxRegion.Pdx1,
                "sfo1" => UploadProjectAvatarResponseSandboxRegion.Sfo1,
                "sin1" => UploadProjectAvatarResponseSandboxRegion.Sin1,
                "syd1" => UploadProjectAvatarResponseSandboxRegion.Syd1,
                "yul1" => UploadProjectAvatarResponseSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}