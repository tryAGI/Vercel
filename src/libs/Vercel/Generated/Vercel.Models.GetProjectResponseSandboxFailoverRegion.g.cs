
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseSandboxFailoverRegion
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
    public static class GetProjectResponseSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSandboxFailoverRegion value)
        {
            return value switch
            {
                GetProjectResponseSandboxFailoverRegion.Arn1 => "arn1",
                GetProjectResponseSandboxFailoverRegion.Bom1 => "bom1",
                GetProjectResponseSandboxFailoverRegion.Cdg1 => "cdg1",
                GetProjectResponseSandboxFailoverRegion.Cle1 => "cle1",
                GetProjectResponseSandboxFailoverRegion.Cpt1 => "cpt1",
                GetProjectResponseSandboxFailoverRegion.Dub1 => "dub1",
                GetProjectResponseSandboxFailoverRegion.Fra1 => "fra1",
                GetProjectResponseSandboxFailoverRegion.Gru1 => "gru1",
                GetProjectResponseSandboxFailoverRegion.Hkg1 => "hkg1",
                GetProjectResponseSandboxFailoverRegion.Hnd1 => "hnd1",
                GetProjectResponseSandboxFailoverRegion.Iad1 => "iad1",
                GetProjectResponseSandboxFailoverRegion.Icn1 => "icn1",
                GetProjectResponseSandboxFailoverRegion.Kix1 => "kix1",
                GetProjectResponseSandboxFailoverRegion.Lhr1 => "lhr1",
                GetProjectResponseSandboxFailoverRegion.Pdx1 => "pdx1",
                GetProjectResponseSandboxFailoverRegion.Sfo1 => "sfo1",
                GetProjectResponseSandboxFailoverRegion.Sin1 => "sin1",
                GetProjectResponseSandboxFailoverRegion.Syd1 => "syd1",
                GetProjectResponseSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => GetProjectResponseSandboxFailoverRegion.Arn1,
                "bom1" => GetProjectResponseSandboxFailoverRegion.Bom1,
                "cdg1" => GetProjectResponseSandboxFailoverRegion.Cdg1,
                "cle1" => GetProjectResponseSandboxFailoverRegion.Cle1,
                "cpt1" => GetProjectResponseSandboxFailoverRegion.Cpt1,
                "dub1" => GetProjectResponseSandboxFailoverRegion.Dub1,
                "fra1" => GetProjectResponseSandboxFailoverRegion.Fra1,
                "gru1" => GetProjectResponseSandboxFailoverRegion.Gru1,
                "hkg1" => GetProjectResponseSandboxFailoverRegion.Hkg1,
                "hnd1" => GetProjectResponseSandboxFailoverRegion.Hnd1,
                "iad1" => GetProjectResponseSandboxFailoverRegion.Iad1,
                "icn1" => GetProjectResponseSandboxFailoverRegion.Icn1,
                "kix1" => GetProjectResponseSandboxFailoverRegion.Kix1,
                "lhr1" => GetProjectResponseSandboxFailoverRegion.Lhr1,
                "pdx1" => GetProjectResponseSandboxFailoverRegion.Pdx1,
                "sfo1" => GetProjectResponseSandboxFailoverRegion.Sfo1,
                "sin1" => GetProjectResponseSandboxFailoverRegion.Sin1,
                "syd1" => GetProjectResponseSandboxFailoverRegion.Syd1,
                "yul1" => GetProjectResponseSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}