
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bSandboxFailoverRegion
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
    public static class AutoSDKSharedbfe68caea048321bSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bSandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKSharedbfe68caea048321bSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}