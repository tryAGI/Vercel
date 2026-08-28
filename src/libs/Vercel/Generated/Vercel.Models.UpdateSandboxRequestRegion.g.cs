
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Vercel region in which to create the sandbox.<br/>
    /// Example: iad1
    /// </summary>
    public enum UpdateSandboxRequestRegion
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
    public static class UpdateSandboxRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSandboxRequestRegion value)
        {
            return value switch
            {
                UpdateSandboxRequestRegion.Arn1 => "arn1",
                UpdateSandboxRequestRegion.Bom1 => "bom1",
                UpdateSandboxRequestRegion.Cdg1 => "cdg1",
                UpdateSandboxRequestRegion.Cle1 => "cle1",
                UpdateSandboxRequestRegion.Cpt1 => "cpt1",
                UpdateSandboxRequestRegion.Dub1 => "dub1",
                UpdateSandboxRequestRegion.Fra1 => "fra1",
                UpdateSandboxRequestRegion.Gru1 => "gru1",
                UpdateSandboxRequestRegion.Hkg1 => "hkg1",
                UpdateSandboxRequestRegion.Hnd1 => "hnd1",
                UpdateSandboxRequestRegion.Iad1 => "iad1",
                UpdateSandboxRequestRegion.Icn1 => "icn1",
                UpdateSandboxRequestRegion.Kix1 => "kix1",
                UpdateSandboxRequestRegion.Lhr1 => "lhr1",
                UpdateSandboxRequestRegion.Pdx1 => "pdx1",
                UpdateSandboxRequestRegion.Sfo1 => "sfo1",
                UpdateSandboxRequestRegion.Sin1 => "sin1",
                UpdateSandboxRequestRegion.Syd1 => "syd1",
                UpdateSandboxRequestRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSandboxRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => UpdateSandboxRequestRegion.Arn1,
                "bom1" => UpdateSandboxRequestRegion.Bom1,
                "cdg1" => UpdateSandboxRequestRegion.Cdg1,
                "cle1" => UpdateSandboxRequestRegion.Cle1,
                "cpt1" => UpdateSandboxRequestRegion.Cpt1,
                "dub1" => UpdateSandboxRequestRegion.Dub1,
                "fra1" => UpdateSandboxRequestRegion.Fra1,
                "gru1" => UpdateSandboxRequestRegion.Gru1,
                "hkg1" => UpdateSandboxRequestRegion.Hkg1,
                "hnd1" => UpdateSandboxRequestRegion.Hnd1,
                "iad1" => UpdateSandboxRequestRegion.Iad1,
                "icn1" => UpdateSandboxRequestRegion.Icn1,
                "kix1" => UpdateSandboxRequestRegion.Kix1,
                "lhr1" => UpdateSandboxRequestRegion.Lhr1,
                "pdx1" => UpdateSandboxRequestRegion.Pdx1,
                "sfo1" => UpdateSandboxRequestRegion.Sfo1,
                "sin1" => UpdateSandboxRequestRegion.Sin1,
                "syd1" => UpdateSandboxRequestRegion.Syd1,
                "yul1" => UpdateSandboxRequestRegion.Yul1,
                _ => null,
            };
        }
    }
}