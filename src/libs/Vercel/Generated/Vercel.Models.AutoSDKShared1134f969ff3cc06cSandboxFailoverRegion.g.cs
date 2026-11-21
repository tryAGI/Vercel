
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion
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
    public static class AutoSDKShared1134f969ff3cc06cSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKShared1134f969ff3cc06cSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}