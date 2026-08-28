
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseSandboxRegion
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
    public static class UpdateMicrofrontendsResponseSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSandboxRegion value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSandboxRegion.Arn1 => "arn1",
                UpdateMicrofrontendsResponseSandboxRegion.Bom1 => "bom1",
                UpdateMicrofrontendsResponseSandboxRegion.Cdg1 => "cdg1",
                UpdateMicrofrontendsResponseSandboxRegion.Cle1 => "cle1",
                UpdateMicrofrontendsResponseSandboxRegion.Cpt1 => "cpt1",
                UpdateMicrofrontendsResponseSandboxRegion.Dub1 => "dub1",
                UpdateMicrofrontendsResponseSandboxRegion.Fra1 => "fra1",
                UpdateMicrofrontendsResponseSandboxRegion.Gru1 => "gru1",
                UpdateMicrofrontendsResponseSandboxRegion.Hkg1 => "hkg1",
                UpdateMicrofrontendsResponseSandboxRegion.Hnd1 => "hnd1",
                UpdateMicrofrontendsResponseSandboxRegion.Iad1 => "iad1",
                UpdateMicrofrontendsResponseSandboxRegion.Icn1 => "icn1",
                UpdateMicrofrontendsResponseSandboxRegion.Kix1 => "kix1",
                UpdateMicrofrontendsResponseSandboxRegion.Lhr1 => "lhr1",
                UpdateMicrofrontendsResponseSandboxRegion.Pdx1 => "pdx1",
                UpdateMicrofrontendsResponseSandboxRegion.Sfo1 => "sfo1",
                UpdateMicrofrontendsResponseSandboxRegion.Sin1 => "sin1",
                UpdateMicrofrontendsResponseSandboxRegion.Syd1 => "syd1",
                UpdateMicrofrontendsResponseSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => UpdateMicrofrontendsResponseSandboxRegion.Arn1,
                "bom1" => UpdateMicrofrontendsResponseSandboxRegion.Bom1,
                "cdg1" => UpdateMicrofrontendsResponseSandboxRegion.Cdg1,
                "cle1" => UpdateMicrofrontendsResponseSandboxRegion.Cle1,
                "cpt1" => UpdateMicrofrontendsResponseSandboxRegion.Cpt1,
                "dub1" => UpdateMicrofrontendsResponseSandboxRegion.Dub1,
                "fra1" => UpdateMicrofrontendsResponseSandboxRegion.Fra1,
                "gru1" => UpdateMicrofrontendsResponseSandboxRegion.Gru1,
                "hkg1" => UpdateMicrofrontendsResponseSandboxRegion.Hkg1,
                "hnd1" => UpdateMicrofrontendsResponseSandboxRegion.Hnd1,
                "iad1" => UpdateMicrofrontendsResponseSandboxRegion.Iad1,
                "icn1" => UpdateMicrofrontendsResponseSandboxRegion.Icn1,
                "kix1" => UpdateMicrofrontendsResponseSandboxRegion.Kix1,
                "lhr1" => UpdateMicrofrontendsResponseSandboxRegion.Lhr1,
                "pdx1" => UpdateMicrofrontendsResponseSandboxRegion.Pdx1,
                "sfo1" => UpdateMicrofrontendsResponseSandboxRegion.Sfo1,
                "sin1" => UpdateMicrofrontendsResponseSandboxRegion.Sin1,
                "syd1" => UpdateMicrofrontendsResponseSandboxRegion.Syd1,
                "yul1" => UpdateMicrofrontendsResponseSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}