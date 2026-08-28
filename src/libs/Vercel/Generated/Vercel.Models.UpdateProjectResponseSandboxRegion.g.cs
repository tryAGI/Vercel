
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseSandboxRegion
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
    public static class UpdateProjectResponseSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSandboxRegion value)
        {
            return value switch
            {
                UpdateProjectResponseSandboxRegion.Arn1 => "arn1",
                UpdateProjectResponseSandboxRegion.Bom1 => "bom1",
                UpdateProjectResponseSandboxRegion.Cdg1 => "cdg1",
                UpdateProjectResponseSandboxRegion.Cle1 => "cle1",
                UpdateProjectResponseSandboxRegion.Cpt1 => "cpt1",
                UpdateProjectResponseSandboxRegion.Dub1 => "dub1",
                UpdateProjectResponseSandboxRegion.Fra1 => "fra1",
                UpdateProjectResponseSandboxRegion.Gru1 => "gru1",
                UpdateProjectResponseSandboxRegion.Hkg1 => "hkg1",
                UpdateProjectResponseSandboxRegion.Hnd1 => "hnd1",
                UpdateProjectResponseSandboxRegion.Iad1 => "iad1",
                UpdateProjectResponseSandboxRegion.Icn1 => "icn1",
                UpdateProjectResponseSandboxRegion.Kix1 => "kix1",
                UpdateProjectResponseSandboxRegion.Lhr1 => "lhr1",
                UpdateProjectResponseSandboxRegion.Pdx1 => "pdx1",
                UpdateProjectResponseSandboxRegion.Sfo1 => "sfo1",
                UpdateProjectResponseSandboxRegion.Sin1 => "sin1",
                UpdateProjectResponseSandboxRegion.Syd1 => "syd1",
                UpdateProjectResponseSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => UpdateProjectResponseSandboxRegion.Arn1,
                "bom1" => UpdateProjectResponseSandboxRegion.Bom1,
                "cdg1" => UpdateProjectResponseSandboxRegion.Cdg1,
                "cle1" => UpdateProjectResponseSandboxRegion.Cle1,
                "cpt1" => UpdateProjectResponseSandboxRegion.Cpt1,
                "dub1" => UpdateProjectResponseSandboxRegion.Dub1,
                "fra1" => UpdateProjectResponseSandboxRegion.Fra1,
                "gru1" => UpdateProjectResponseSandboxRegion.Gru1,
                "hkg1" => UpdateProjectResponseSandboxRegion.Hkg1,
                "hnd1" => UpdateProjectResponseSandboxRegion.Hnd1,
                "iad1" => UpdateProjectResponseSandboxRegion.Iad1,
                "icn1" => UpdateProjectResponseSandboxRegion.Icn1,
                "kix1" => UpdateProjectResponseSandboxRegion.Kix1,
                "lhr1" => UpdateProjectResponseSandboxRegion.Lhr1,
                "pdx1" => UpdateProjectResponseSandboxRegion.Pdx1,
                "sfo1" => UpdateProjectResponseSandboxRegion.Sfo1,
                "sin1" => UpdateProjectResponseSandboxRegion.Sin1,
                "syd1" => UpdateProjectResponseSandboxRegion.Syd1,
                "yul1" => UpdateProjectResponseSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}