
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Region where the drive is stored. Defaults to iad1.<br/>
    /// Default Value: iad1<br/>
    /// Example: iad1
    /// </summary>
    public enum GetOrCreateDriveRequestRegion
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
    public static class GetOrCreateDriveRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrCreateDriveRequestRegion value)
        {
            return value switch
            {
                GetOrCreateDriveRequestRegion.Arn1 => "arn1",
                GetOrCreateDriveRequestRegion.Bom1 => "bom1",
                GetOrCreateDriveRequestRegion.Cdg1 => "cdg1",
                GetOrCreateDriveRequestRegion.Cle1 => "cle1",
                GetOrCreateDriveRequestRegion.Cpt1 => "cpt1",
                GetOrCreateDriveRequestRegion.Dub1 => "dub1",
                GetOrCreateDriveRequestRegion.Fra1 => "fra1",
                GetOrCreateDriveRequestRegion.Gru1 => "gru1",
                GetOrCreateDriveRequestRegion.Hkg1 => "hkg1",
                GetOrCreateDriveRequestRegion.Hnd1 => "hnd1",
                GetOrCreateDriveRequestRegion.Iad1 => "iad1",
                GetOrCreateDriveRequestRegion.Icn1 => "icn1",
                GetOrCreateDriveRequestRegion.Kix1 => "kix1",
                GetOrCreateDriveRequestRegion.Lhr1 => "lhr1",
                GetOrCreateDriveRequestRegion.Pdx1 => "pdx1",
                GetOrCreateDriveRequestRegion.Sfo1 => "sfo1",
                GetOrCreateDriveRequestRegion.Sin1 => "sin1",
                GetOrCreateDriveRequestRegion.Syd1 => "syd1",
                GetOrCreateDriveRequestRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrCreateDriveRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => GetOrCreateDriveRequestRegion.Arn1,
                "bom1" => GetOrCreateDriveRequestRegion.Bom1,
                "cdg1" => GetOrCreateDriveRequestRegion.Cdg1,
                "cle1" => GetOrCreateDriveRequestRegion.Cle1,
                "cpt1" => GetOrCreateDriveRequestRegion.Cpt1,
                "dub1" => GetOrCreateDriveRequestRegion.Dub1,
                "fra1" => GetOrCreateDriveRequestRegion.Fra1,
                "gru1" => GetOrCreateDriveRequestRegion.Gru1,
                "hkg1" => GetOrCreateDriveRequestRegion.Hkg1,
                "hnd1" => GetOrCreateDriveRequestRegion.Hnd1,
                "iad1" => GetOrCreateDriveRequestRegion.Iad1,
                "icn1" => GetOrCreateDriveRequestRegion.Icn1,
                "kix1" => GetOrCreateDriveRequestRegion.Kix1,
                "lhr1" => GetOrCreateDriveRequestRegion.Lhr1,
                "pdx1" => GetOrCreateDriveRequestRegion.Pdx1,
                "sfo1" => GetOrCreateDriveRequestRegion.Sfo1,
                "sin1" => GetOrCreateDriveRequestRegion.Sin1,
                "syd1" => GetOrCreateDriveRequestRegion.Syd1,
                "yul1" => GetOrCreateDriveRequestRegion.Yul1,
                _ => null,
            };
        }
    }
}