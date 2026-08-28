
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateSandboxRequestFailoverRegion
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
    public static class UpdateSandboxRequestFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSandboxRequestFailoverRegion value)
        {
            return value switch
            {
                UpdateSandboxRequestFailoverRegion.Arn1 => "arn1",
                UpdateSandboxRequestFailoverRegion.Bom1 => "bom1",
                UpdateSandboxRequestFailoverRegion.Cdg1 => "cdg1",
                UpdateSandboxRequestFailoverRegion.Cle1 => "cle1",
                UpdateSandboxRequestFailoverRegion.Cpt1 => "cpt1",
                UpdateSandboxRequestFailoverRegion.Dub1 => "dub1",
                UpdateSandboxRequestFailoverRegion.Fra1 => "fra1",
                UpdateSandboxRequestFailoverRegion.Gru1 => "gru1",
                UpdateSandboxRequestFailoverRegion.Hkg1 => "hkg1",
                UpdateSandboxRequestFailoverRegion.Hnd1 => "hnd1",
                UpdateSandboxRequestFailoverRegion.Iad1 => "iad1",
                UpdateSandboxRequestFailoverRegion.Icn1 => "icn1",
                UpdateSandboxRequestFailoverRegion.Kix1 => "kix1",
                UpdateSandboxRequestFailoverRegion.Lhr1 => "lhr1",
                UpdateSandboxRequestFailoverRegion.Pdx1 => "pdx1",
                UpdateSandboxRequestFailoverRegion.Sfo1 => "sfo1",
                UpdateSandboxRequestFailoverRegion.Sin1 => "sin1",
                UpdateSandboxRequestFailoverRegion.Syd1 => "syd1",
                UpdateSandboxRequestFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSandboxRequestFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => UpdateSandboxRequestFailoverRegion.Arn1,
                "bom1" => UpdateSandboxRequestFailoverRegion.Bom1,
                "cdg1" => UpdateSandboxRequestFailoverRegion.Cdg1,
                "cle1" => UpdateSandboxRequestFailoverRegion.Cle1,
                "cpt1" => UpdateSandboxRequestFailoverRegion.Cpt1,
                "dub1" => UpdateSandboxRequestFailoverRegion.Dub1,
                "fra1" => UpdateSandboxRequestFailoverRegion.Fra1,
                "gru1" => UpdateSandboxRequestFailoverRegion.Gru1,
                "hkg1" => UpdateSandboxRequestFailoverRegion.Hkg1,
                "hnd1" => UpdateSandboxRequestFailoverRegion.Hnd1,
                "iad1" => UpdateSandboxRequestFailoverRegion.Iad1,
                "icn1" => UpdateSandboxRequestFailoverRegion.Icn1,
                "kix1" => UpdateSandboxRequestFailoverRegion.Kix1,
                "lhr1" => UpdateSandboxRequestFailoverRegion.Lhr1,
                "pdx1" => UpdateSandboxRequestFailoverRegion.Pdx1,
                "sfo1" => UpdateSandboxRequestFailoverRegion.Sfo1,
                "sin1" => UpdateSandboxRequestFailoverRegion.Sin1,
                "syd1" => UpdateSandboxRequestFailoverRegion.Syd1,
                "yul1" => UpdateSandboxRequestFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}