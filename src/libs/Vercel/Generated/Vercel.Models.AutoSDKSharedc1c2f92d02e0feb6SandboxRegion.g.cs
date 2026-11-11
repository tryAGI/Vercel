
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6SandboxRegion
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
    public static class AutoSDKSharedc1c2f92d02e0feb6SandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6SandboxRegion value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Arn1 => "arn1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Bom1 => "bom1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Cdg1 => "cdg1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Cle1 => "cle1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Cpt1 => "cpt1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Dub1 => "dub1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Fra1 => "fra1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Gru1 => "gru1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Hkg1 => "hkg1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Hnd1 => "hnd1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Iad1 => "iad1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Icn1 => "icn1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Kix1 => "kix1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Lhr1 => "lhr1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Pdx1 => "pdx1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Sfo1 => "sfo1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Sin1 => "sin1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Syd1 => "syd1",
                AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6SandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Arn1,
                "bom1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Bom1,
                "cdg1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Cdg1,
                "cle1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Cle1,
                "cpt1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Cpt1,
                "dub1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Dub1,
                "fra1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Fra1,
                "gru1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Gru1,
                "hkg1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Hkg1,
                "hnd1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Hnd1,
                "iad1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Iad1,
                "icn1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Icn1,
                "kix1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Kix1,
                "lhr1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Lhr1,
                "pdx1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Pdx1,
                "sfo1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Sfo1,
                "sin1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Sin1,
                "syd1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Syd1,
                "yul1" => AutoSDKSharedc1c2f92d02e0feb6SandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}