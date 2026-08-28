
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Vercel region in which to create the sandbox.<br/>
    /// Default Value: [iad1, sfo1, cle1, cdg1, fra1, arn1, sin1, pdx1, lhr1, icn1, bom1, cpt1, dub1, gru1, hkg1, syd1, yul1, hnd1, kix1]<br/>
    /// Example: iad1
    /// </summary>
    public enum CreateSandboxesV4RequestRegion
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
    public static class CreateSandboxesV4RequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV4RequestRegion value)
        {
            return value switch
            {
                CreateSandboxesV4RequestRegion.Arn1 => "arn1",
                CreateSandboxesV4RequestRegion.Bom1 => "bom1",
                CreateSandboxesV4RequestRegion.Cdg1 => "cdg1",
                CreateSandboxesV4RequestRegion.Cle1 => "cle1",
                CreateSandboxesV4RequestRegion.Cpt1 => "cpt1",
                CreateSandboxesV4RequestRegion.Dub1 => "dub1",
                CreateSandboxesV4RequestRegion.Fra1 => "fra1",
                CreateSandboxesV4RequestRegion.Gru1 => "gru1",
                CreateSandboxesV4RequestRegion.Hkg1 => "hkg1",
                CreateSandboxesV4RequestRegion.Hnd1 => "hnd1",
                CreateSandboxesV4RequestRegion.Iad1 => "iad1",
                CreateSandboxesV4RequestRegion.Icn1 => "icn1",
                CreateSandboxesV4RequestRegion.Kix1 => "kix1",
                CreateSandboxesV4RequestRegion.Lhr1 => "lhr1",
                CreateSandboxesV4RequestRegion.Pdx1 => "pdx1",
                CreateSandboxesV4RequestRegion.Sfo1 => "sfo1",
                CreateSandboxesV4RequestRegion.Sin1 => "sin1",
                CreateSandboxesV4RequestRegion.Syd1 => "syd1",
                CreateSandboxesV4RequestRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV4RequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => CreateSandboxesV4RequestRegion.Arn1,
                "bom1" => CreateSandboxesV4RequestRegion.Bom1,
                "cdg1" => CreateSandboxesV4RequestRegion.Cdg1,
                "cle1" => CreateSandboxesV4RequestRegion.Cle1,
                "cpt1" => CreateSandboxesV4RequestRegion.Cpt1,
                "dub1" => CreateSandboxesV4RequestRegion.Dub1,
                "fra1" => CreateSandboxesV4RequestRegion.Fra1,
                "gru1" => CreateSandboxesV4RequestRegion.Gru1,
                "hkg1" => CreateSandboxesV4RequestRegion.Hkg1,
                "hnd1" => CreateSandboxesV4RequestRegion.Hnd1,
                "iad1" => CreateSandboxesV4RequestRegion.Iad1,
                "icn1" => CreateSandboxesV4RequestRegion.Icn1,
                "kix1" => CreateSandboxesV4RequestRegion.Kix1,
                "lhr1" => CreateSandboxesV4RequestRegion.Lhr1,
                "pdx1" => CreateSandboxesV4RequestRegion.Pdx1,
                "sfo1" => CreateSandboxesV4RequestRegion.Sfo1,
                "sin1" => CreateSandboxesV4RequestRegion.Sin1,
                "syd1" => CreateSandboxesV4RequestRegion.Syd1,
                "yul1" => CreateSandboxesV4RequestRegion.Yul1,
                _ => null,
            };
        }
    }
}