
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseSandboxFailoverRegion
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
    public static class UpdateProjectResponseSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSandboxFailoverRegion value)
        {
            return value switch
            {
                UpdateProjectResponseSandboxFailoverRegion.Arn1 => "arn1",
                UpdateProjectResponseSandboxFailoverRegion.Bom1 => "bom1",
                UpdateProjectResponseSandboxFailoverRegion.Cdg1 => "cdg1",
                UpdateProjectResponseSandboxFailoverRegion.Cle1 => "cle1",
                UpdateProjectResponseSandboxFailoverRegion.Cpt1 => "cpt1",
                UpdateProjectResponseSandboxFailoverRegion.Dub1 => "dub1",
                UpdateProjectResponseSandboxFailoverRegion.Fra1 => "fra1",
                UpdateProjectResponseSandboxFailoverRegion.Gru1 => "gru1",
                UpdateProjectResponseSandboxFailoverRegion.Hkg1 => "hkg1",
                UpdateProjectResponseSandboxFailoverRegion.Hnd1 => "hnd1",
                UpdateProjectResponseSandboxFailoverRegion.Iad1 => "iad1",
                UpdateProjectResponseSandboxFailoverRegion.Icn1 => "icn1",
                UpdateProjectResponseSandboxFailoverRegion.Kix1 => "kix1",
                UpdateProjectResponseSandboxFailoverRegion.Lhr1 => "lhr1",
                UpdateProjectResponseSandboxFailoverRegion.Pdx1 => "pdx1",
                UpdateProjectResponseSandboxFailoverRegion.Sfo1 => "sfo1",
                UpdateProjectResponseSandboxFailoverRegion.Sin1 => "sin1",
                UpdateProjectResponseSandboxFailoverRegion.Syd1 => "syd1",
                UpdateProjectResponseSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => UpdateProjectResponseSandboxFailoverRegion.Arn1,
                "bom1" => UpdateProjectResponseSandboxFailoverRegion.Bom1,
                "cdg1" => UpdateProjectResponseSandboxFailoverRegion.Cdg1,
                "cle1" => UpdateProjectResponseSandboxFailoverRegion.Cle1,
                "cpt1" => UpdateProjectResponseSandboxFailoverRegion.Cpt1,
                "dub1" => UpdateProjectResponseSandboxFailoverRegion.Dub1,
                "fra1" => UpdateProjectResponseSandboxFailoverRegion.Fra1,
                "gru1" => UpdateProjectResponseSandboxFailoverRegion.Gru1,
                "hkg1" => UpdateProjectResponseSandboxFailoverRegion.Hkg1,
                "hnd1" => UpdateProjectResponseSandboxFailoverRegion.Hnd1,
                "iad1" => UpdateProjectResponseSandboxFailoverRegion.Iad1,
                "icn1" => UpdateProjectResponseSandboxFailoverRegion.Icn1,
                "kix1" => UpdateProjectResponseSandboxFailoverRegion.Kix1,
                "lhr1" => UpdateProjectResponseSandboxFailoverRegion.Lhr1,
                "pdx1" => UpdateProjectResponseSandboxFailoverRegion.Pdx1,
                "sfo1" => UpdateProjectResponseSandboxFailoverRegion.Sfo1,
                "sin1" => UpdateProjectResponseSandboxFailoverRegion.Sin1,
                "syd1" => UpdateProjectResponseSandboxFailoverRegion.Syd1,
                "yul1" => UpdateProjectResponseSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}