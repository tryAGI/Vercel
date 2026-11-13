
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f99f1735f329c6cSandboxRegion
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
    public static class AutoSDKShared0f99f1735f329c6cSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f99f1735f329c6cSandboxRegion value)
        {
            return value switch
            {
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Arn1 => "arn1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Bom1 => "bom1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Cdg1 => "cdg1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Cle1 => "cle1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Cpt1 => "cpt1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Dub1 => "dub1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Fra1 => "fra1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Gru1 => "gru1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Hkg1 => "hkg1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Hnd1 => "hnd1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Iad1 => "iad1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Icn1 => "icn1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Kix1 => "kix1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Lhr1 => "lhr1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Pdx1 => "pdx1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Sfo1 => "sfo1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Sin1 => "sin1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Syd1 => "syd1",
                AutoSDKShared0f99f1735f329c6cSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f99f1735f329c6cSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Arn1,
                "bom1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Bom1,
                "cdg1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Cdg1,
                "cle1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Cle1,
                "cpt1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Cpt1,
                "dub1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Dub1,
                "fra1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Fra1,
                "gru1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Gru1,
                "hkg1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Hkg1,
                "hnd1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Hnd1,
                "iad1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Iad1,
                "icn1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Icn1,
                "kix1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Kix1,
                "lhr1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Lhr1,
                "pdx1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Pdx1,
                "sfo1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Sfo1,
                "sin1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Sin1,
                "syd1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Syd1,
                "yul1" => AutoSDKShared0f99f1735f329c6cSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}