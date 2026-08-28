
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Vercel region sandboxes in this project are created in by default.<br/>
    /// Example: iad1
    /// </summary>
    public enum UpdateProjectRequestSandboxRegion
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
    public static class UpdateProjectRequestSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestSandboxRegion value)
        {
            return value switch
            {
                UpdateProjectRequestSandboxRegion.Arn1 => "arn1",
                UpdateProjectRequestSandboxRegion.Bom1 => "bom1",
                UpdateProjectRequestSandboxRegion.Cdg1 => "cdg1",
                UpdateProjectRequestSandboxRegion.Cle1 => "cle1",
                UpdateProjectRequestSandboxRegion.Cpt1 => "cpt1",
                UpdateProjectRequestSandboxRegion.Dub1 => "dub1",
                UpdateProjectRequestSandboxRegion.Fra1 => "fra1",
                UpdateProjectRequestSandboxRegion.Gru1 => "gru1",
                UpdateProjectRequestSandboxRegion.Hkg1 => "hkg1",
                UpdateProjectRequestSandboxRegion.Hnd1 => "hnd1",
                UpdateProjectRequestSandboxRegion.Iad1 => "iad1",
                UpdateProjectRequestSandboxRegion.Icn1 => "icn1",
                UpdateProjectRequestSandboxRegion.Kix1 => "kix1",
                UpdateProjectRequestSandboxRegion.Lhr1 => "lhr1",
                UpdateProjectRequestSandboxRegion.Pdx1 => "pdx1",
                UpdateProjectRequestSandboxRegion.Sfo1 => "sfo1",
                UpdateProjectRequestSandboxRegion.Sin1 => "sin1",
                UpdateProjectRequestSandboxRegion.Syd1 => "syd1",
                UpdateProjectRequestSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => UpdateProjectRequestSandboxRegion.Arn1,
                "bom1" => UpdateProjectRequestSandboxRegion.Bom1,
                "cdg1" => UpdateProjectRequestSandboxRegion.Cdg1,
                "cle1" => UpdateProjectRequestSandboxRegion.Cle1,
                "cpt1" => UpdateProjectRequestSandboxRegion.Cpt1,
                "dub1" => UpdateProjectRequestSandboxRegion.Dub1,
                "fra1" => UpdateProjectRequestSandboxRegion.Fra1,
                "gru1" => UpdateProjectRequestSandboxRegion.Gru1,
                "hkg1" => UpdateProjectRequestSandboxRegion.Hkg1,
                "hnd1" => UpdateProjectRequestSandboxRegion.Hnd1,
                "iad1" => UpdateProjectRequestSandboxRegion.Iad1,
                "icn1" => UpdateProjectRequestSandboxRegion.Icn1,
                "kix1" => UpdateProjectRequestSandboxRegion.Kix1,
                "lhr1" => UpdateProjectRequestSandboxRegion.Lhr1,
                "pdx1" => UpdateProjectRequestSandboxRegion.Pdx1,
                "sfo1" => UpdateProjectRequestSandboxRegion.Sfo1,
                "sin1" => UpdateProjectRequestSandboxRegion.Sin1,
                "syd1" => UpdateProjectRequestSandboxRegion.Syd1,
                "yul1" => UpdateProjectRequestSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}