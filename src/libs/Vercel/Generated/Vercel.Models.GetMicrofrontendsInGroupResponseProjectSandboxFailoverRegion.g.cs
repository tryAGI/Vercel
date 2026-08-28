
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion
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
    public static class GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Arn1 => "arn1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Bom1 => "bom1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Cdg1 => "cdg1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Cle1 => "cle1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Cpt1 => "cpt1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Dub1 => "dub1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Fra1 => "fra1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Gru1 => "gru1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Hkg1 => "hkg1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Hnd1 => "hnd1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Iad1 => "iad1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Icn1 => "icn1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Kix1 => "kix1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Lhr1 => "lhr1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Pdx1 => "pdx1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Sfo1 => "sfo1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Sin1 => "sin1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Syd1 => "syd1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Arn1,
                "bom1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Bom1,
                "cdg1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Cdg1,
                "cle1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Cle1,
                "cpt1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Cpt1,
                "dub1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Dub1,
                "fra1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Fra1,
                "gru1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Gru1,
                "hkg1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Hkg1,
                "hnd1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Hnd1,
                "iad1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Iad1,
                "icn1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Icn1,
                "kix1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Kix1,
                "lhr1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Lhr1,
                "pdx1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Pdx1,
                "sfo1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Sfo1,
                "sin1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Sin1,
                "syd1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Syd1,
                "yul1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}