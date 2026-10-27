
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion
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
    public static class AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKSharedc9c79e81839bbccdSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}