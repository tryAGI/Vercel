
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373SandboxRegion
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
    public static class AutoSDKShared94b26a5607c7a373SandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373SandboxRegion value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373SandboxRegion.Arn1 => "arn1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Bom1 => "bom1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Cdg1 => "cdg1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Cle1 => "cle1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Cpt1 => "cpt1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Dub1 => "dub1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Fra1 => "fra1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Gru1 => "gru1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Hkg1 => "hkg1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Hnd1 => "hnd1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Iad1 => "iad1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Icn1 => "icn1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Kix1 => "kix1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Lhr1 => "lhr1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Pdx1 => "pdx1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Sfo1 => "sfo1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Sin1 => "sin1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Syd1 => "syd1",
                AutoSDKShared94b26a5607c7a373SandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373SandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Arn1,
                "bom1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Bom1,
                "cdg1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Cdg1,
                "cle1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Cle1,
                "cpt1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Cpt1,
                "dub1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Dub1,
                "fra1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Fra1,
                "gru1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Gru1,
                "hkg1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Hkg1,
                "hnd1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Hnd1,
                "iad1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Iad1,
                "icn1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Icn1,
                "kix1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Kix1,
                "lhr1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Lhr1,
                "pdx1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Pdx1,
                "sfo1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Sfo1,
                "sin1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Sin1,
                "syd1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Syd1,
                "yul1" => AutoSDKShared94b26a5607c7a373SandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}