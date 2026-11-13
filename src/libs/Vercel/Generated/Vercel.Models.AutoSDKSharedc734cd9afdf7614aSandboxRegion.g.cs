
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc734cd9afdf7614aSandboxRegion
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
    public static class AutoSDKSharedc734cd9afdf7614aSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc734cd9afdf7614aSandboxRegion value)
        {
            return value switch
            {
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Arn1 => "arn1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Bom1 => "bom1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Cdg1 => "cdg1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Cle1 => "cle1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Cpt1 => "cpt1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Dub1 => "dub1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Fra1 => "fra1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Gru1 => "gru1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Hkg1 => "hkg1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Hnd1 => "hnd1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Iad1 => "iad1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Icn1 => "icn1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Kix1 => "kix1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Lhr1 => "lhr1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Pdx1 => "pdx1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Sfo1 => "sfo1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Sin1 => "sin1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Syd1 => "syd1",
                AutoSDKSharedc734cd9afdf7614aSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc734cd9afdf7614aSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Arn1,
                "bom1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Bom1,
                "cdg1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Cdg1,
                "cle1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Cle1,
                "cpt1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Cpt1,
                "dub1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Dub1,
                "fra1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Fra1,
                "gru1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Gru1,
                "hkg1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Hkg1,
                "hnd1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Hnd1,
                "iad1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Iad1,
                "icn1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Icn1,
                "kix1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Kix1,
                "lhr1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Lhr1,
                "pdx1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Pdx1,
                "sfo1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Sfo1,
                "sin1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Sin1,
                "syd1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Syd1,
                "yul1" => AutoSDKSharedc734cd9afdf7614aSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}