
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared223443184387411fSandboxFailoverRegion
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
    public static class AutoSDKShared223443184387411fSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared223443184387411fSandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKShared223443184387411fSandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKShared223443184387411fSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared223443184387411fSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKShared223443184387411fSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}