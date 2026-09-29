
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bSandboxFailoverRegion
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
    public static class AutoSDKShared26233794f6c8981bSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bSandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKShared26233794f6c8981bSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}