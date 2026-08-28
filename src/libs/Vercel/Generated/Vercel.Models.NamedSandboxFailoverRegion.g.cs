
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The regions the sandbox fails over to. Empty when it does not fail over.<br/>
    /// Example: [sfo1, cle1]
    /// </summary>
    public enum NamedSandboxFailoverRegion
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
    public static class NamedSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamedSandboxFailoverRegion value)
        {
            return value switch
            {
                NamedSandboxFailoverRegion.Arn1 => "arn1",
                NamedSandboxFailoverRegion.Bom1 => "bom1",
                NamedSandboxFailoverRegion.Cdg1 => "cdg1",
                NamedSandboxFailoverRegion.Cle1 => "cle1",
                NamedSandboxFailoverRegion.Cpt1 => "cpt1",
                NamedSandboxFailoverRegion.Dub1 => "dub1",
                NamedSandboxFailoverRegion.Fra1 => "fra1",
                NamedSandboxFailoverRegion.Gru1 => "gru1",
                NamedSandboxFailoverRegion.Hkg1 => "hkg1",
                NamedSandboxFailoverRegion.Hnd1 => "hnd1",
                NamedSandboxFailoverRegion.Iad1 => "iad1",
                NamedSandboxFailoverRegion.Icn1 => "icn1",
                NamedSandboxFailoverRegion.Kix1 => "kix1",
                NamedSandboxFailoverRegion.Lhr1 => "lhr1",
                NamedSandboxFailoverRegion.Pdx1 => "pdx1",
                NamedSandboxFailoverRegion.Sfo1 => "sfo1",
                NamedSandboxFailoverRegion.Sin1 => "sin1",
                NamedSandboxFailoverRegion.Syd1 => "syd1",
                NamedSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamedSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => NamedSandboxFailoverRegion.Arn1,
                "bom1" => NamedSandboxFailoverRegion.Bom1,
                "cdg1" => NamedSandboxFailoverRegion.Cdg1,
                "cle1" => NamedSandboxFailoverRegion.Cle1,
                "cpt1" => NamedSandboxFailoverRegion.Cpt1,
                "dub1" => NamedSandboxFailoverRegion.Dub1,
                "fra1" => NamedSandboxFailoverRegion.Fra1,
                "gru1" => NamedSandboxFailoverRegion.Gru1,
                "hkg1" => NamedSandboxFailoverRegion.Hkg1,
                "hnd1" => NamedSandboxFailoverRegion.Hnd1,
                "iad1" => NamedSandboxFailoverRegion.Iad1,
                "icn1" => NamedSandboxFailoverRegion.Icn1,
                "kix1" => NamedSandboxFailoverRegion.Kix1,
                "lhr1" => NamedSandboxFailoverRegion.Lhr1,
                "pdx1" => NamedSandboxFailoverRegion.Pdx1,
                "sfo1" => NamedSandboxFailoverRegion.Sfo1,
                "sin1" => NamedSandboxFailoverRegion.Sin1,
                "syd1" => NamedSandboxFailoverRegion.Syd1,
                "yul1" => NamedSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}