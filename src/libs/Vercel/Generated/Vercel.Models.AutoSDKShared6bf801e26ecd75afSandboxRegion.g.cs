
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afSandboxRegion
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
    public static class AutoSDKShared6bf801e26ecd75afSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afSandboxRegion value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Arn1 => "arn1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Bom1 => "bom1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Cdg1 => "cdg1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Cle1 => "cle1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Cpt1 => "cpt1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Dub1 => "dub1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Fra1 => "fra1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Gru1 => "gru1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Hkg1 => "hkg1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Hnd1 => "hnd1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Iad1 => "iad1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Icn1 => "icn1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Kix1 => "kix1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Lhr1 => "lhr1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Pdx1 => "pdx1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Sfo1 => "sfo1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Sin1 => "sin1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Syd1 => "syd1",
                AutoSDKShared6bf801e26ecd75afSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Arn1,
                "bom1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Bom1,
                "cdg1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Cdg1,
                "cle1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Cle1,
                "cpt1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Cpt1,
                "dub1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Dub1,
                "fra1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Fra1,
                "gru1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Gru1,
                "hkg1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Hkg1,
                "hnd1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Hnd1,
                "iad1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Iad1,
                "icn1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Icn1,
                "kix1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Kix1,
                "lhr1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Lhr1,
                "pdx1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Pdx1,
                "sfo1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Sfo1,
                "sin1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Sin1,
                "syd1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Syd1,
                "yul1" => AutoSDKShared6bf801e26ecd75afSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}