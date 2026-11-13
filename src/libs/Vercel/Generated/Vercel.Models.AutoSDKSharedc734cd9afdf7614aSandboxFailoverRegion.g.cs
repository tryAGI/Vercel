
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion
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
    public static class AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKSharedc734cd9afdf7614aSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}