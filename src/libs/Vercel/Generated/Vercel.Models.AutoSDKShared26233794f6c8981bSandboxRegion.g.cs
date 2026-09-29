
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bSandboxRegion
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
    public static class AutoSDKShared26233794f6c8981bSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bSandboxRegion value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bSandboxRegion.Arn1 => "arn1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Bom1 => "bom1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Cdg1 => "cdg1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Cle1 => "cle1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Cpt1 => "cpt1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Dub1 => "dub1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Fra1 => "fra1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Gru1 => "gru1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Hkg1 => "hkg1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Hnd1 => "hnd1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Iad1 => "iad1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Icn1 => "icn1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Kix1 => "kix1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Lhr1 => "lhr1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Pdx1 => "pdx1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Sfo1 => "sfo1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Sin1 => "sin1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Syd1 => "syd1",
                AutoSDKShared26233794f6c8981bSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared26233794f6c8981bSandboxRegion.Arn1,
                "bom1" => AutoSDKShared26233794f6c8981bSandboxRegion.Bom1,
                "cdg1" => AutoSDKShared26233794f6c8981bSandboxRegion.Cdg1,
                "cle1" => AutoSDKShared26233794f6c8981bSandboxRegion.Cle1,
                "cpt1" => AutoSDKShared26233794f6c8981bSandboxRegion.Cpt1,
                "dub1" => AutoSDKShared26233794f6c8981bSandboxRegion.Dub1,
                "fra1" => AutoSDKShared26233794f6c8981bSandboxRegion.Fra1,
                "gru1" => AutoSDKShared26233794f6c8981bSandboxRegion.Gru1,
                "hkg1" => AutoSDKShared26233794f6c8981bSandboxRegion.Hkg1,
                "hnd1" => AutoSDKShared26233794f6c8981bSandboxRegion.Hnd1,
                "iad1" => AutoSDKShared26233794f6c8981bSandboxRegion.Iad1,
                "icn1" => AutoSDKShared26233794f6c8981bSandboxRegion.Icn1,
                "kix1" => AutoSDKShared26233794f6c8981bSandboxRegion.Kix1,
                "lhr1" => AutoSDKShared26233794f6c8981bSandboxRegion.Lhr1,
                "pdx1" => AutoSDKShared26233794f6c8981bSandboxRegion.Pdx1,
                "sfo1" => AutoSDKShared26233794f6c8981bSandboxRegion.Sfo1,
                "sin1" => AutoSDKShared26233794f6c8981bSandboxRegion.Sin1,
                "syd1" => AutoSDKShared26233794f6c8981bSandboxRegion.Syd1,
                "yul1" => AutoSDKShared26233794f6c8981bSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}