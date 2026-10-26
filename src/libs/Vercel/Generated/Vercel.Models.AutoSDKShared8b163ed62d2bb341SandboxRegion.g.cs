
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341SandboxRegion
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
    public static class AutoSDKShared8b163ed62d2bb341SandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341SandboxRegion value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Arn1 => "arn1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Bom1 => "bom1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Cdg1 => "cdg1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Cle1 => "cle1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Cpt1 => "cpt1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Dub1 => "dub1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Fra1 => "fra1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Gru1 => "gru1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Hkg1 => "hkg1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Hnd1 => "hnd1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Iad1 => "iad1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Icn1 => "icn1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Kix1 => "kix1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Lhr1 => "lhr1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Pdx1 => "pdx1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Sfo1 => "sfo1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Sin1 => "sin1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Syd1 => "syd1",
                AutoSDKShared8b163ed62d2bb341SandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341SandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Arn1,
                "bom1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Bom1,
                "cdg1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Cdg1,
                "cle1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Cle1,
                "cpt1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Cpt1,
                "dub1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Dub1,
                "fra1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Fra1,
                "gru1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Gru1,
                "hkg1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Hkg1,
                "hnd1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Hnd1,
                "iad1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Iad1,
                "icn1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Icn1,
                "kix1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Kix1,
                "lhr1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Lhr1,
                "pdx1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Pdx1,
                "sfo1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Sfo1,
                "sin1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Sin1,
                "syd1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Syd1,
                "yul1" => AutoSDKShared8b163ed62d2bb341SandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}