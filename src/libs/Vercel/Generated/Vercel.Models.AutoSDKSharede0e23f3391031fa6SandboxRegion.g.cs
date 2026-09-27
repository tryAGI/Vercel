
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6SandboxRegion
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
    public static class AutoSDKSharede0e23f3391031fa6SandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6SandboxRegion value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Arn1 => "arn1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Bom1 => "bom1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Cdg1 => "cdg1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Cle1 => "cle1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Cpt1 => "cpt1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Dub1 => "dub1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Fra1 => "fra1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Gru1 => "gru1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Hkg1 => "hkg1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Hnd1 => "hnd1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Iad1 => "iad1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Icn1 => "icn1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Kix1 => "kix1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Lhr1 => "lhr1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Pdx1 => "pdx1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Sfo1 => "sfo1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Sin1 => "sin1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Syd1 => "syd1",
                AutoSDKSharede0e23f3391031fa6SandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6SandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Arn1,
                "bom1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Bom1,
                "cdg1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Cdg1,
                "cle1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Cle1,
                "cpt1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Cpt1,
                "dub1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Dub1,
                "fra1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Fra1,
                "gru1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Gru1,
                "hkg1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Hkg1,
                "hnd1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Hnd1,
                "iad1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Iad1,
                "icn1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Icn1,
                "kix1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Kix1,
                "lhr1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Lhr1,
                "pdx1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Pdx1,
                "sfo1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Sfo1,
                "sin1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Sin1,
                "syd1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Syd1,
                "yul1" => AutoSDKSharede0e23f3391031fa6SandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}