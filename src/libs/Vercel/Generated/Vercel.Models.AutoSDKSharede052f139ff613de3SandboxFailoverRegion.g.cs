
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3SandboxFailoverRegion
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
    public static class AutoSDKSharede052f139ff613de3SandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3SandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3SandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKSharede052f139ff613de3SandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}