
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fSandboxFailoverRegion
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
    public static class AutoSDKShareda223f19b9c37327fSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fSandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKShareda223f19b9c37327fSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}