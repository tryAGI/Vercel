
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8e5249ecd42210edSandboxRegion
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
    public static class AutoSDKShared8e5249ecd42210edSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8e5249ecd42210edSandboxRegion value)
        {
            return value switch
            {
                AutoSDKShared8e5249ecd42210edSandboxRegion.Arn1 => "arn1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Bom1 => "bom1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Cdg1 => "cdg1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Cle1 => "cle1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Cpt1 => "cpt1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Dub1 => "dub1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Fra1 => "fra1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Gru1 => "gru1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Hkg1 => "hkg1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Hnd1 => "hnd1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Iad1 => "iad1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Icn1 => "icn1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Kix1 => "kix1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Lhr1 => "lhr1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Pdx1 => "pdx1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Sfo1 => "sfo1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Sin1 => "sin1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Syd1 => "syd1",
                AutoSDKShared8e5249ecd42210edSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8e5249ecd42210edSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Arn1,
                "bom1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Bom1,
                "cdg1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Cdg1,
                "cle1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Cle1,
                "cpt1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Cpt1,
                "dub1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Dub1,
                "fra1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Fra1,
                "gru1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Gru1,
                "hkg1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Hkg1,
                "hnd1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Hnd1,
                "iad1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Iad1,
                "icn1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Icn1,
                "kix1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Kix1,
                "lhr1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Lhr1,
                "pdx1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Pdx1,
                "sfo1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Sfo1,
                "sin1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Sin1,
                "syd1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Syd1,
                "yul1" => AutoSDKShared8e5249ecd42210edSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}