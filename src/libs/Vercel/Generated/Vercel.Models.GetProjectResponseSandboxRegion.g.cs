
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseSandboxRegion
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
    public static class GetProjectResponseSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSandboxRegion value)
        {
            return value switch
            {
                GetProjectResponseSandboxRegion.Arn1 => "arn1",
                GetProjectResponseSandboxRegion.Bom1 => "bom1",
                GetProjectResponseSandboxRegion.Cdg1 => "cdg1",
                GetProjectResponseSandboxRegion.Cle1 => "cle1",
                GetProjectResponseSandboxRegion.Cpt1 => "cpt1",
                GetProjectResponseSandboxRegion.Dub1 => "dub1",
                GetProjectResponseSandboxRegion.Fra1 => "fra1",
                GetProjectResponseSandboxRegion.Gru1 => "gru1",
                GetProjectResponseSandboxRegion.Hkg1 => "hkg1",
                GetProjectResponseSandboxRegion.Hnd1 => "hnd1",
                GetProjectResponseSandboxRegion.Iad1 => "iad1",
                GetProjectResponseSandboxRegion.Icn1 => "icn1",
                GetProjectResponseSandboxRegion.Kix1 => "kix1",
                GetProjectResponseSandboxRegion.Lhr1 => "lhr1",
                GetProjectResponseSandboxRegion.Pdx1 => "pdx1",
                GetProjectResponseSandboxRegion.Sfo1 => "sfo1",
                GetProjectResponseSandboxRegion.Sin1 => "sin1",
                GetProjectResponseSandboxRegion.Syd1 => "syd1",
                GetProjectResponseSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => GetProjectResponseSandboxRegion.Arn1,
                "bom1" => GetProjectResponseSandboxRegion.Bom1,
                "cdg1" => GetProjectResponseSandboxRegion.Cdg1,
                "cle1" => GetProjectResponseSandboxRegion.Cle1,
                "cpt1" => GetProjectResponseSandboxRegion.Cpt1,
                "dub1" => GetProjectResponseSandboxRegion.Dub1,
                "fra1" => GetProjectResponseSandboxRegion.Fra1,
                "gru1" => GetProjectResponseSandboxRegion.Gru1,
                "hkg1" => GetProjectResponseSandboxRegion.Hkg1,
                "hnd1" => GetProjectResponseSandboxRegion.Hnd1,
                "iad1" => GetProjectResponseSandboxRegion.Iad1,
                "icn1" => GetProjectResponseSandboxRegion.Icn1,
                "kix1" => GetProjectResponseSandboxRegion.Kix1,
                "lhr1" => GetProjectResponseSandboxRegion.Lhr1,
                "pdx1" => GetProjectResponseSandboxRegion.Pdx1,
                "sfo1" => GetProjectResponseSandboxRegion.Sfo1,
                "sin1" => GetProjectResponseSandboxRegion.Sin1,
                "syd1" => GetProjectResponseSandboxRegion.Syd1,
                "yul1" => GetProjectResponseSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}