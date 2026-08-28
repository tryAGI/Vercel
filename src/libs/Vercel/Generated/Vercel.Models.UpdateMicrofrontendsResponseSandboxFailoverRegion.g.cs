
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseSandboxFailoverRegion
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
    public static class UpdateMicrofrontendsResponseSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSandboxFailoverRegion value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Arn1 => "arn1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Bom1 => "bom1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Cdg1 => "cdg1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Cle1 => "cle1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Cpt1 => "cpt1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Dub1 => "dub1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Fra1 => "fra1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Gru1 => "gru1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Hkg1 => "hkg1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Hnd1 => "hnd1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Iad1 => "iad1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Icn1 => "icn1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Kix1 => "kix1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Lhr1 => "lhr1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Pdx1 => "pdx1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Sfo1 => "sfo1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Sin1 => "sin1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Syd1 => "syd1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Arn1,
                "bom1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Bom1,
                "cdg1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Cdg1,
                "cle1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Cle1,
                "cpt1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Cpt1,
                "dub1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Dub1,
                "fra1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Fra1,
                "gru1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Gru1,
                "hkg1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Hkg1,
                "hnd1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Hnd1,
                "iad1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Iad1,
                "icn1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Icn1,
                "kix1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Kix1,
                "lhr1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Lhr1,
                "pdx1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Pdx1,
                "sfo1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Sfo1,
                "sin1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Sin1,
                "syd1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Syd1,
                "yul1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}