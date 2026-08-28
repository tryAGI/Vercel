
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSandboxRegion
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
    public static class GetProjectsResponseVariant3ProjectSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSandboxRegion value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSandboxRegion.Arn1 => "arn1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Bom1 => "bom1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Cdg1 => "cdg1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Cle1 => "cle1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Cpt1 => "cpt1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Dub1 => "dub1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Fra1 => "fra1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Gru1 => "gru1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Hkg1 => "hkg1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Hnd1 => "hnd1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Iad1 => "iad1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Icn1 => "icn1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Kix1 => "kix1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Lhr1 => "lhr1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Pdx1 => "pdx1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Sfo1 => "sfo1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Sin1 => "sin1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Syd1 => "syd1",
                GetProjectsResponseVariant3ProjectSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => GetProjectsResponseVariant3ProjectSandboxRegion.Arn1,
                "bom1" => GetProjectsResponseVariant3ProjectSandboxRegion.Bom1,
                "cdg1" => GetProjectsResponseVariant3ProjectSandboxRegion.Cdg1,
                "cle1" => GetProjectsResponseVariant3ProjectSandboxRegion.Cle1,
                "cpt1" => GetProjectsResponseVariant3ProjectSandboxRegion.Cpt1,
                "dub1" => GetProjectsResponseVariant3ProjectSandboxRegion.Dub1,
                "fra1" => GetProjectsResponseVariant3ProjectSandboxRegion.Fra1,
                "gru1" => GetProjectsResponseVariant3ProjectSandboxRegion.Gru1,
                "hkg1" => GetProjectsResponseVariant3ProjectSandboxRegion.Hkg1,
                "hnd1" => GetProjectsResponseVariant3ProjectSandboxRegion.Hnd1,
                "iad1" => GetProjectsResponseVariant3ProjectSandboxRegion.Iad1,
                "icn1" => GetProjectsResponseVariant3ProjectSandboxRegion.Icn1,
                "kix1" => GetProjectsResponseVariant3ProjectSandboxRegion.Kix1,
                "lhr1" => GetProjectsResponseVariant3ProjectSandboxRegion.Lhr1,
                "pdx1" => GetProjectsResponseVariant3ProjectSandboxRegion.Pdx1,
                "sfo1" => GetProjectsResponseVariant3ProjectSandboxRegion.Sfo1,
                "sin1" => GetProjectsResponseVariant3ProjectSandboxRegion.Sin1,
                "syd1" => GetProjectsResponseVariant3ProjectSandboxRegion.Syd1,
                "yul1" => GetProjectsResponseVariant3ProjectSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}