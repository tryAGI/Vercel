
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19eSandboxRegion
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
    public static class AutoSDKSharede27e7ff1aa86f19eSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19eSandboxRegion value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Arn1 => "arn1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Bom1 => "bom1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Cdg1 => "cdg1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Cle1 => "cle1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Cpt1 => "cpt1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Dub1 => "dub1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Fra1 => "fra1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Gru1 => "gru1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Hkg1 => "hkg1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Hnd1 => "hnd1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Iad1 => "iad1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Icn1 => "icn1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Kix1 => "kix1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Lhr1 => "lhr1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Pdx1 => "pdx1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Sfo1 => "sfo1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Sin1 => "sin1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Syd1 => "syd1",
                AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19eSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Arn1,
                "bom1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Bom1,
                "cdg1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Cdg1,
                "cle1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Cle1,
                "cpt1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Cpt1,
                "dub1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Dub1,
                "fra1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Fra1,
                "gru1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Gru1,
                "hkg1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Hkg1,
                "hnd1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Hnd1,
                "iad1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Iad1,
                "icn1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Icn1,
                "kix1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Kix1,
                "lhr1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Lhr1,
                "pdx1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Pdx1,
                "sfo1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Sfo1,
                "sin1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Sin1,
                "syd1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Syd1,
                "yul1" => AutoSDKSharede27e7ff1aa86f19eSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}