
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3SandboxRegion
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
    public static class AutoSDKSharede052f139ff613de3SandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3SandboxRegion value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3SandboxRegion.Arn1 => "arn1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Bom1 => "bom1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Cdg1 => "cdg1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Cle1 => "cle1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Cpt1 => "cpt1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Dub1 => "dub1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Fra1 => "fra1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Gru1 => "gru1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Hkg1 => "hkg1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Hnd1 => "hnd1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Iad1 => "iad1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Icn1 => "icn1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Kix1 => "kix1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Lhr1 => "lhr1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Pdx1 => "pdx1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Sfo1 => "sfo1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Sin1 => "sin1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Syd1 => "syd1",
                AutoSDKSharede052f139ff613de3SandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3SandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharede052f139ff613de3SandboxRegion.Arn1,
                "bom1" => AutoSDKSharede052f139ff613de3SandboxRegion.Bom1,
                "cdg1" => AutoSDKSharede052f139ff613de3SandboxRegion.Cdg1,
                "cle1" => AutoSDKSharede052f139ff613de3SandboxRegion.Cle1,
                "cpt1" => AutoSDKSharede052f139ff613de3SandboxRegion.Cpt1,
                "dub1" => AutoSDKSharede052f139ff613de3SandboxRegion.Dub1,
                "fra1" => AutoSDKSharede052f139ff613de3SandboxRegion.Fra1,
                "gru1" => AutoSDKSharede052f139ff613de3SandboxRegion.Gru1,
                "hkg1" => AutoSDKSharede052f139ff613de3SandboxRegion.Hkg1,
                "hnd1" => AutoSDKSharede052f139ff613de3SandboxRegion.Hnd1,
                "iad1" => AutoSDKSharede052f139ff613de3SandboxRegion.Iad1,
                "icn1" => AutoSDKSharede052f139ff613de3SandboxRegion.Icn1,
                "kix1" => AutoSDKSharede052f139ff613de3SandboxRegion.Kix1,
                "lhr1" => AutoSDKSharede052f139ff613de3SandboxRegion.Lhr1,
                "pdx1" => AutoSDKSharede052f139ff613de3SandboxRegion.Pdx1,
                "sfo1" => AutoSDKSharede052f139ff613de3SandboxRegion.Sfo1,
                "sin1" => AutoSDKSharede052f139ff613de3SandboxRegion.Sin1,
                "syd1" => AutoSDKSharede052f139ff613de3SandboxRegion.Syd1,
                "yul1" => AutoSDKSharede052f139ff613de3SandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}