
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Region where the drive is stored. Defaults to iad1.<br/>
    /// Default Value: iad1<br/>
    /// Example: iad1
    /// </summary>
    public enum GetOrCreateDriveV1RequestRegion
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
    public static class GetOrCreateDriveV1RequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrCreateDriveV1RequestRegion value)
        {
            return value switch
            {
                GetOrCreateDriveV1RequestRegion.Arn1 => "arn1",
                GetOrCreateDriveV1RequestRegion.Bom1 => "bom1",
                GetOrCreateDriveV1RequestRegion.Cdg1 => "cdg1",
                GetOrCreateDriveV1RequestRegion.Cle1 => "cle1",
                GetOrCreateDriveV1RequestRegion.Cpt1 => "cpt1",
                GetOrCreateDriveV1RequestRegion.Dub1 => "dub1",
                GetOrCreateDriveV1RequestRegion.Fra1 => "fra1",
                GetOrCreateDriveV1RequestRegion.Gru1 => "gru1",
                GetOrCreateDriveV1RequestRegion.Hkg1 => "hkg1",
                GetOrCreateDriveV1RequestRegion.Hnd1 => "hnd1",
                GetOrCreateDriveV1RequestRegion.Iad1 => "iad1",
                GetOrCreateDriveV1RequestRegion.Icn1 => "icn1",
                GetOrCreateDriveV1RequestRegion.Kix1 => "kix1",
                GetOrCreateDriveV1RequestRegion.Lhr1 => "lhr1",
                GetOrCreateDriveV1RequestRegion.Pdx1 => "pdx1",
                GetOrCreateDriveV1RequestRegion.Sfo1 => "sfo1",
                GetOrCreateDriveV1RequestRegion.Sin1 => "sin1",
                GetOrCreateDriveV1RequestRegion.Syd1 => "syd1",
                GetOrCreateDriveV1RequestRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrCreateDriveV1RequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => GetOrCreateDriveV1RequestRegion.Arn1,
                "bom1" => GetOrCreateDriveV1RequestRegion.Bom1,
                "cdg1" => GetOrCreateDriveV1RequestRegion.Cdg1,
                "cle1" => GetOrCreateDriveV1RequestRegion.Cle1,
                "cpt1" => GetOrCreateDriveV1RequestRegion.Cpt1,
                "dub1" => GetOrCreateDriveV1RequestRegion.Dub1,
                "fra1" => GetOrCreateDriveV1RequestRegion.Fra1,
                "gru1" => GetOrCreateDriveV1RequestRegion.Gru1,
                "hkg1" => GetOrCreateDriveV1RequestRegion.Hkg1,
                "hnd1" => GetOrCreateDriveV1RequestRegion.Hnd1,
                "iad1" => GetOrCreateDriveV1RequestRegion.Iad1,
                "icn1" => GetOrCreateDriveV1RequestRegion.Icn1,
                "kix1" => GetOrCreateDriveV1RequestRegion.Kix1,
                "lhr1" => GetOrCreateDriveV1RequestRegion.Lhr1,
                "pdx1" => GetOrCreateDriveV1RequestRegion.Pdx1,
                "sfo1" => GetOrCreateDriveV1RequestRegion.Sfo1,
                "sin1" => GetOrCreateDriveV1RequestRegion.Sin1,
                "syd1" => GetOrCreateDriveV1RequestRegion.Syd1,
                "yul1" => GetOrCreateDriveV1RequestRegion.Yul1,
                _ => null,
            };
        }
    }
}