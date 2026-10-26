
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion
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
    public static class AutoSDKShared8b163ed62d2bb341SandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKShared8b163ed62d2bb341SandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}