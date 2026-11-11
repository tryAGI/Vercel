
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4d5a5876dd584f34SandboxRegion
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
    public static class AutoSDKShared4d5a5876dd584f34SandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4d5a5876dd584f34SandboxRegion value)
        {
            return value switch
            {
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Arn1 => "arn1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Bom1 => "bom1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Cdg1 => "cdg1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Cle1 => "cle1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Cpt1 => "cpt1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Dub1 => "dub1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Fra1 => "fra1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Gru1 => "gru1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Hkg1 => "hkg1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Hnd1 => "hnd1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Iad1 => "iad1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Icn1 => "icn1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Kix1 => "kix1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Lhr1 => "lhr1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Pdx1 => "pdx1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Sfo1 => "sfo1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Sin1 => "sin1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Syd1 => "syd1",
                AutoSDKShared4d5a5876dd584f34SandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4d5a5876dd584f34SandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Arn1,
                "bom1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Bom1,
                "cdg1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Cdg1,
                "cle1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Cle1,
                "cpt1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Cpt1,
                "dub1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Dub1,
                "fra1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Fra1,
                "gru1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Gru1,
                "hkg1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Hkg1,
                "hnd1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Hnd1,
                "iad1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Iad1,
                "icn1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Icn1,
                "kix1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Kix1,
                "lhr1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Lhr1,
                "pdx1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Pdx1,
                "sfo1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Sfo1,
                "sin1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Sin1,
                "syd1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Syd1,
                "yul1" => AutoSDKShared4d5a5876dd584f34SandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}