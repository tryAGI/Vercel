
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseSandboxRegion
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
    public static class CreateProjectResponseSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSandboxRegion value)
        {
            return value switch
            {
                CreateProjectResponseSandboxRegion.Arn1 => "arn1",
                CreateProjectResponseSandboxRegion.Bom1 => "bom1",
                CreateProjectResponseSandboxRegion.Cdg1 => "cdg1",
                CreateProjectResponseSandboxRegion.Cle1 => "cle1",
                CreateProjectResponseSandboxRegion.Cpt1 => "cpt1",
                CreateProjectResponseSandboxRegion.Dub1 => "dub1",
                CreateProjectResponseSandboxRegion.Fra1 => "fra1",
                CreateProjectResponseSandboxRegion.Gru1 => "gru1",
                CreateProjectResponseSandboxRegion.Hkg1 => "hkg1",
                CreateProjectResponseSandboxRegion.Hnd1 => "hnd1",
                CreateProjectResponseSandboxRegion.Iad1 => "iad1",
                CreateProjectResponseSandboxRegion.Icn1 => "icn1",
                CreateProjectResponseSandboxRegion.Kix1 => "kix1",
                CreateProjectResponseSandboxRegion.Lhr1 => "lhr1",
                CreateProjectResponseSandboxRegion.Pdx1 => "pdx1",
                CreateProjectResponseSandboxRegion.Sfo1 => "sfo1",
                CreateProjectResponseSandboxRegion.Sin1 => "sin1",
                CreateProjectResponseSandboxRegion.Syd1 => "syd1",
                CreateProjectResponseSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => CreateProjectResponseSandboxRegion.Arn1,
                "bom1" => CreateProjectResponseSandboxRegion.Bom1,
                "cdg1" => CreateProjectResponseSandboxRegion.Cdg1,
                "cle1" => CreateProjectResponseSandboxRegion.Cle1,
                "cpt1" => CreateProjectResponseSandboxRegion.Cpt1,
                "dub1" => CreateProjectResponseSandboxRegion.Dub1,
                "fra1" => CreateProjectResponseSandboxRegion.Fra1,
                "gru1" => CreateProjectResponseSandboxRegion.Gru1,
                "hkg1" => CreateProjectResponseSandboxRegion.Hkg1,
                "hnd1" => CreateProjectResponseSandboxRegion.Hnd1,
                "iad1" => CreateProjectResponseSandboxRegion.Iad1,
                "icn1" => CreateProjectResponseSandboxRegion.Icn1,
                "kix1" => CreateProjectResponseSandboxRegion.Kix1,
                "lhr1" => CreateProjectResponseSandboxRegion.Lhr1,
                "pdx1" => CreateProjectResponseSandboxRegion.Pdx1,
                "sfo1" => CreateProjectResponseSandboxRegion.Sfo1,
                "sin1" => CreateProjectResponseSandboxRegion.Sin1,
                "syd1" => CreateProjectResponseSandboxRegion.Syd1,
                "yul1" => CreateProjectResponseSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}