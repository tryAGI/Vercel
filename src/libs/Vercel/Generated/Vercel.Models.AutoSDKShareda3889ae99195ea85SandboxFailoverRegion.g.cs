
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85SandboxFailoverRegion
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
    public static class AutoSDKShareda3889ae99195ea85SandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85SandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85SandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKShareda3889ae99195ea85SandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}