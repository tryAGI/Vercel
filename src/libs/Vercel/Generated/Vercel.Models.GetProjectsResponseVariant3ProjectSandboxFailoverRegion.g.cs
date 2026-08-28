
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSandboxFailoverRegion
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
    public static class GetProjectsResponseVariant3ProjectSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSandboxFailoverRegion value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Arn1 => "arn1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Bom1 => "bom1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Cdg1 => "cdg1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Cle1 => "cle1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Cpt1 => "cpt1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Dub1 => "dub1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Fra1 => "fra1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Gru1 => "gru1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Hkg1 => "hkg1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Hnd1 => "hnd1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Iad1 => "iad1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Icn1 => "icn1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Kix1 => "kix1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Lhr1 => "lhr1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Pdx1 => "pdx1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Sfo1 => "sfo1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Sin1 => "sin1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Syd1 => "syd1",
                GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Arn1,
                "bom1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Bom1,
                "cdg1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Cdg1,
                "cle1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Cle1,
                "cpt1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Cpt1,
                "dub1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Dub1,
                "fra1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Fra1,
                "gru1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Gru1,
                "hkg1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Hkg1,
                "hnd1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Hnd1,
                "iad1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Iad1,
                "icn1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Icn1,
                "kix1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Kix1,
                "lhr1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Lhr1,
                "pdx1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Pdx1,
                "sfo1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Sfo1,
                "sin1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Sin1,
                "syd1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Syd1,
                "yul1" => GetProjectsResponseVariant3ProjectSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}