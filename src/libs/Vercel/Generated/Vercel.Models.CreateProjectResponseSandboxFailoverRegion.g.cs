
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseSandboxFailoverRegion
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
    public static class CreateProjectResponseSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSandboxFailoverRegion value)
        {
            return value switch
            {
                CreateProjectResponseSandboxFailoverRegion.Arn1 => "arn1",
                CreateProjectResponseSandboxFailoverRegion.Bom1 => "bom1",
                CreateProjectResponseSandboxFailoverRegion.Cdg1 => "cdg1",
                CreateProjectResponseSandboxFailoverRegion.Cle1 => "cle1",
                CreateProjectResponseSandboxFailoverRegion.Cpt1 => "cpt1",
                CreateProjectResponseSandboxFailoverRegion.Dub1 => "dub1",
                CreateProjectResponseSandboxFailoverRegion.Fra1 => "fra1",
                CreateProjectResponseSandboxFailoverRegion.Gru1 => "gru1",
                CreateProjectResponseSandboxFailoverRegion.Hkg1 => "hkg1",
                CreateProjectResponseSandboxFailoverRegion.Hnd1 => "hnd1",
                CreateProjectResponseSandboxFailoverRegion.Iad1 => "iad1",
                CreateProjectResponseSandboxFailoverRegion.Icn1 => "icn1",
                CreateProjectResponseSandboxFailoverRegion.Kix1 => "kix1",
                CreateProjectResponseSandboxFailoverRegion.Lhr1 => "lhr1",
                CreateProjectResponseSandboxFailoverRegion.Pdx1 => "pdx1",
                CreateProjectResponseSandboxFailoverRegion.Sfo1 => "sfo1",
                CreateProjectResponseSandboxFailoverRegion.Sin1 => "sin1",
                CreateProjectResponseSandboxFailoverRegion.Syd1 => "syd1",
                CreateProjectResponseSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => CreateProjectResponseSandboxFailoverRegion.Arn1,
                "bom1" => CreateProjectResponseSandboxFailoverRegion.Bom1,
                "cdg1" => CreateProjectResponseSandboxFailoverRegion.Cdg1,
                "cle1" => CreateProjectResponseSandboxFailoverRegion.Cle1,
                "cpt1" => CreateProjectResponseSandboxFailoverRegion.Cpt1,
                "dub1" => CreateProjectResponseSandboxFailoverRegion.Dub1,
                "fra1" => CreateProjectResponseSandboxFailoverRegion.Fra1,
                "gru1" => CreateProjectResponseSandboxFailoverRegion.Gru1,
                "hkg1" => CreateProjectResponseSandboxFailoverRegion.Hkg1,
                "hnd1" => CreateProjectResponseSandboxFailoverRegion.Hnd1,
                "iad1" => CreateProjectResponseSandboxFailoverRegion.Iad1,
                "icn1" => CreateProjectResponseSandboxFailoverRegion.Icn1,
                "kix1" => CreateProjectResponseSandboxFailoverRegion.Kix1,
                "lhr1" => CreateProjectResponseSandboxFailoverRegion.Lhr1,
                "pdx1" => CreateProjectResponseSandboxFailoverRegion.Pdx1,
                "sfo1" => CreateProjectResponseSandboxFailoverRegion.Sfo1,
                "sin1" => CreateProjectResponseSandboxFailoverRegion.Sin1,
                "syd1" => CreateProjectResponseSandboxFailoverRegion.Syd1,
                "yul1" => CreateProjectResponseSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}