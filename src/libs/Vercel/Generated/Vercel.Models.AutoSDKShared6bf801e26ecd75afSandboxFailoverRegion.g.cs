
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion
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
    public static class AutoSDKShared6bf801e26ecd75afSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKShared6bf801e26ecd75afSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}