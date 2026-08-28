
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSandboxesByNameForkV2RequestFailoverRegion
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
    public static class CreateSandboxesByNameForkV2RequestFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesByNameForkV2RequestFailoverRegion value)
        {
            return value switch
            {
                CreateSandboxesByNameForkV2RequestFailoverRegion.Arn1 => "arn1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Bom1 => "bom1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Cdg1 => "cdg1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Cle1 => "cle1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Cpt1 => "cpt1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Dub1 => "dub1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Fra1 => "fra1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Gru1 => "gru1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Hkg1 => "hkg1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Hnd1 => "hnd1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Iad1 => "iad1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Icn1 => "icn1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Kix1 => "kix1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Lhr1 => "lhr1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Pdx1 => "pdx1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Sfo1 => "sfo1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Sin1 => "sin1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Syd1 => "syd1",
                CreateSandboxesByNameForkV2RequestFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesByNameForkV2RequestFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Arn1,
                "bom1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Bom1,
                "cdg1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Cdg1,
                "cle1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Cle1,
                "cpt1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Cpt1,
                "dub1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Dub1,
                "fra1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Fra1,
                "gru1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Gru1,
                "hkg1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Hkg1,
                "hnd1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Hnd1,
                "iad1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Iad1,
                "icn1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Icn1,
                "kix1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Kix1,
                "lhr1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Lhr1,
                "pdx1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Pdx1,
                "sfo1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Sfo1,
                "sin1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Sin1,
                "syd1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Syd1,
                "yul1" => CreateSandboxesByNameForkV2RequestFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}