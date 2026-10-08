
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion
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
    public static class AutoSDKSharede870b907cc1fb37eSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKSharede870b907cc1fb37eSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}