
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbSandboxRegion
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
    public static class AutoSDKSharedba7c6b12ca723bfbSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbSandboxRegion value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Arn1 => "arn1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Bom1 => "bom1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Cdg1 => "cdg1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Cle1 => "cle1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Cpt1 => "cpt1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Dub1 => "dub1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Fra1 => "fra1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Gru1 => "gru1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Hkg1 => "hkg1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Hnd1 => "hnd1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Iad1 => "iad1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Icn1 => "icn1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Kix1 => "kix1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Lhr1 => "lhr1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Pdx1 => "pdx1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Sfo1 => "sfo1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Sin1 => "sin1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Syd1 => "syd1",
                AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Arn1,
                "bom1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Bom1,
                "cdg1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Cdg1,
                "cle1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Cle1,
                "cpt1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Cpt1,
                "dub1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Dub1,
                "fra1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Fra1,
                "gru1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Gru1,
                "hkg1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Hkg1,
                "hnd1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Hnd1,
                "iad1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Iad1,
                "icn1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Icn1,
                "kix1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Kix1,
                "lhr1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Lhr1,
                "pdx1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Pdx1,
                "sfo1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Sfo1,
                "sin1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Sin1,
                "syd1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Syd1,
                "yul1" => AutoSDKSharedba7c6b12ca723bfbSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}