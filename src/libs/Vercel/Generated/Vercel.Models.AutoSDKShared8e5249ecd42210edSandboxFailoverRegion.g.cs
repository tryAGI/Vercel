
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8e5249ecd42210edSandboxFailoverRegion
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
    public static class AutoSDKShared8e5249ecd42210edSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8e5249ecd42210edSandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8e5249ecd42210edSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKShared8e5249ecd42210edSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}