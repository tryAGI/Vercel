
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bSandboxRegion
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
    public static class AutoSDKSharedbfe68caea048321bSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bSandboxRegion value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bSandboxRegion.Arn1 => "arn1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Bom1 => "bom1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Cdg1 => "cdg1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Cle1 => "cle1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Cpt1 => "cpt1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Dub1 => "dub1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Fra1 => "fra1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Gru1 => "gru1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Hkg1 => "hkg1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Hnd1 => "hnd1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Iad1 => "iad1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Icn1 => "icn1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Kix1 => "kix1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Lhr1 => "lhr1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Pdx1 => "pdx1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Sfo1 => "sfo1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Sin1 => "sin1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Syd1 => "syd1",
                AutoSDKSharedbfe68caea048321bSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Arn1,
                "bom1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Bom1,
                "cdg1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Cdg1,
                "cle1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Cle1,
                "cpt1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Cpt1,
                "dub1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Dub1,
                "fra1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Fra1,
                "gru1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Gru1,
                "hkg1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Hkg1,
                "hnd1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Hnd1,
                "iad1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Iad1,
                "icn1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Icn1,
                "kix1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Kix1,
                "lhr1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Lhr1,
                "pdx1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Pdx1,
                "sfo1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Sfo1,
                "sin1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Sin1,
                "syd1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Syd1,
                "yul1" => AutoSDKSharedbfe68caea048321bSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}