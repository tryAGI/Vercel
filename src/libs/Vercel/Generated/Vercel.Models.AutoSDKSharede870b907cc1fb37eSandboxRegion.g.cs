
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eSandboxRegion
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
    public static class AutoSDKSharede870b907cc1fb37eSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eSandboxRegion value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Arn1 => "arn1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Bom1 => "bom1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Cdg1 => "cdg1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Cle1 => "cle1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Cpt1 => "cpt1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Dub1 => "dub1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Fra1 => "fra1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Gru1 => "gru1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Hkg1 => "hkg1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Hnd1 => "hnd1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Iad1 => "iad1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Icn1 => "icn1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Kix1 => "kix1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Lhr1 => "lhr1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Pdx1 => "pdx1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Sfo1 => "sfo1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Sin1 => "sin1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Syd1 => "syd1",
                AutoSDKSharede870b907cc1fb37eSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Arn1,
                "bom1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Bom1,
                "cdg1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Cdg1,
                "cle1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Cle1,
                "cpt1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Cpt1,
                "dub1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Dub1,
                "fra1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Fra1,
                "gru1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Gru1,
                "hkg1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Hkg1,
                "hnd1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Hnd1,
                "iad1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Iad1,
                "icn1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Icn1,
                "kix1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Kix1,
                "lhr1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Lhr1,
                "pdx1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Pdx1,
                "sfo1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Sfo1,
                "sin1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Sin1,
                "syd1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Syd1,
                "yul1" => AutoSDKSharede870b907cc1fb37eSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}