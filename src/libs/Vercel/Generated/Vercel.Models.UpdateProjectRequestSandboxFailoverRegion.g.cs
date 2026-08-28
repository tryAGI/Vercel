
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectRequestSandboxFailoverRegion
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
    public static class UpdateProjectRequestSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestSandboxFailoverRegion value)
        {
            return value switch
            {
                UpdateProjectRequestSandboxFailoverRegion.Arn1 => "arn1",
                UpdateProjectRequestSandboxFailoverRegion.Bom1 => "bom1",
                UpdateProjectRequestSandboxFailoverRegion.Cdg1 => "cdg1",
                UpdateProjectRequestSandboxFailoverRegion.Cle1 => "cle1",
                UpdateProjectRequestSandboxFailoverRegion.Cpt1 => "cpt1",
                UpdateProjectRequestSandboxFailoverRegion.Dub1 => "dub1",
                UpdateProjectRequestSandboxFailoverRegion.Fra1 => "fra1",
                UpdateProjectRequestSandboxFailoverRegion.Gru1 => "gru1",
                UpdateProjectRequestSandboxFailoverRegion.Hkg1 => "hkg1",
                UpdateProjectRequestSandboxFailoverRegion.Hnd1 => "hnd1",
                UpdateProjectRequestSandboxFailoverRegion.Iad1 => "iad1",
                UpdateProjectRequestSandboxFailoverRegion.Icn1 => "icn1",
                UpdateProjectRequestSandboxFailoverRegion.Kix1 => "kix1",
                UpdateProjectRequestSandboxFailoverRegion.Lhr1 => "lhr1",
                UpdateProjectRequestSandboxFailoverRegion.Pdx1 => "pdx1",
                UpdateProjectRequestSandboxFailoverRegion.Sfo1 => "sfo1",
                UpdateProjectRequestSandboxFailoverRegion.Sin1 => "sin1",
                UpdateProjectRequestSandboxFailoverRegion.Syd1 => "syd1",
                UpdateProjectRequestSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => UpdateProjectRequestSandboxFailoverRegion.Arn1,
                "bom1" => UpdateProjectRequestSandboxFailoverRegion.Bom1,
                "cdg1" => UpdateProjectRequestSandboxFailoverRegion.Cdg1,
                "cle1" => UpdateProjectRequestSandboxFailoverRegion.Cle1,
                "cpt1" => UpdateProjectRequestSandboxFailoverRegion.Cpt1,
                "dub1" => UpdateProjectRequestSandboxFailoverRegion.Dub1,
                "fra1" => UpdateProjectRequestSandboxFailoverRegion.Fra1,
                "gru1" => UpdateProjectRequestSandboxFailoverRegion.Gru1,
                "hkg1" => UpdateProjectRequestSandboxFailoverRegion.Hkg1,
                "hnd1" => UpdateProjectRequestSandboxFailoverRegion.Hnd1,
                "iad1" => UpdateProjectRequestSandboxFailoverRegion.Iad1,
                "icn1" => UpdateProjectRequestSandboxFailoverRegion.Icn1,
                "kix1" => UpdateProjectRequestSandboxFailoverRegion.Kix1,
                "lhr1" => UpdateProjectRequestSandboxFailoverRegion.Lhr1,
                "pdx1" => UpdateProjectRequestSandboxFailoverRegion.Pdx1,
                "sfo1" => UpdateProjectRequestSandboxFailoverRegion.Sfo1,
                "sin1" => UpdateProjectRequestSandboxFailoverRegion.Sin1,
                "syd1" => UpdateProjectRequestSandboxFailoverRegion.Syd1,
                "yul1" => UpdateProjectRequestSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}