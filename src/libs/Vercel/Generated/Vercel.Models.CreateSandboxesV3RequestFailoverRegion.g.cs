
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSandboxesV3RequestFailoverRegion
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
    public static class CreateSandboxesV3RequestFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV3RequestFailoverRegion value)
        {
            return value switch
            {
                CreateSandboxesV3RequestFailoverRegion.Arn1 => "arn1",
                CreateSandboxesV3RequestFailoverRegion.Bom1 => "bom1",
                CreateSandboxesV3RequestFailoverRegion.Cdg1 => "cdg1",
                CreateSandboxesV3RequestFailoverRegion.Cle1 => "cle1",
                CreateSandboxesV3RequestFailoverRegion.Cpt1 => "cpt1",
                CreateSandboxesV3RequestFailoverRegion.Dub1 => "dub1",
                CreateSandboxesV3RequestFailoverRegion.Fra1 => "fra1",
                CreateSandboxesV3RequestFailoverRegion.Gru1 => "gru1",
                CreateSandboxesV3RequestFailoverRegion.Hkg1 => "hkg1",
                CreateSandboxesV3RequestFailoverRegion.Hnd1 => "hnd1",
                CreateSandboxesV3RequestFailoverRegion.Iad1 => "iad1",
                CreateSandboxesV3RequestFailoverRegion.Icn1 => "icn1",
                CreateSandboxesV3RequestFailoverRegion.Kix1 => "kix1",
                CreateSandboxesV3RequestFailoverRegion.Lhr1 => "lhr1",
                CreateSandboxesV3RequestFailoverRegion.Pdx1 => "pdx1",
                CreateSandboxesV3RequestFailoverRegion.Sfo1 => "sfo1",
                CreateSandboxesV3RequestFailoverRegion.Sin1 => "sin1",
                CreateSandboxesV3RequestFailoverRegion.Syd1 => "syd1",
                CreateSandboxesV3RequestFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV3RequestFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => CreateSandboxesV3RequestFailoverRegion.Arn1,
                "bom1" => CreateSandboxesV3RequestFailoverRegion.Bom1,
                "cdg1" => CreateSandboxesV3RequestFailoverRegion.Cdg1,
                "cle1" => CreateSandboxesV3RequestFailoverRegion.Cle1,
                "cpt1" => CreateSandboxesV3RequestFailoverRegion.Cpt1,
                "dub1" => CreateSandboxesV3RequestFailoverRegion.Dub1,
                "fra1" => CreateSandboxesV3RequestFailoverRegion.Fra1,
                "gru1" => CreateSandboxesV3RequestFailoverRegion.Gru1,
                "hkg1" => CreateSandboxesV3RequestFailoverRegion.Hkg1,
                "hnd1" => CreateSandboxesV3RequestFailoverRegion.Hnd1,
                "iad1" => CreateSandboxesV3RequestFailoverRegion.Iad1,
                "icn1" => CreateSandboxesV3RequestFailoverRegion.Icn1,
                "kix1" => CreateSandboxesV3RequestFailoverRegion.Kix1,
                "lhr1" => CreateSandboxesV3RequestFailoverRegion.Lhr1,
                "pdx1" => CreateSandboxesV3RequestFailoverRegion.Pdx1,
                "sfo1" => CreateSandboxesV3RequestFailoverRegion.Sfo1,
                "sin1" => CreateSandboxesV3RequestFailoverRegion.Sin1,
                "syd1" => CreateSandboxesV3RequestFailoverRegion.Syd1,
                "yul1" => CreateSandboxesV3RequestFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}