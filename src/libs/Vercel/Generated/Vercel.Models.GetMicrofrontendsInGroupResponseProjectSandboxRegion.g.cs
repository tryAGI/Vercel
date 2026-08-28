
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSandboxRegion
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
    public static class GetMicrofrontendsInGroupResponseProjectSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSandboxRegion value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Arn1 => "arn1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Bom1 => "bom1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Cdg1 => "cdg1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Cle1 => "cle1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Cpt1 => "cpt1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Dub1 => "dub1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Fra1 => "fra1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Gru1 => "gru1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Hkg1 => "hkg1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Hnd1 => "hnd1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Iad1 => "iad1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Icn1 => "icn1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Kix1 => "kix1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Lhr1 => "lhr1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Pdx1 => "pdx1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Sfo1 => "sfo1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Sin1 => "sin1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Syd1 => "syd1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Arn1,
                "bom1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Bom1,
                "cdg1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Cdg1,
                "cle1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Cle1,
                "cpt1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Cpt1,
                "dub1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Dub1,
                "fra1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Fra1,
                "gru1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Gru1,
                "hkg1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Hkg1,
                "hnd1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Hnd1,
                "iad1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Iad1,
                "icn1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Icn1,
                "kix1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Kix1,
                "lhr1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Lhr1,
                "pdx1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Pdx1,
                "sfo1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Sfo1,
                "sin1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Sin1,
                "syd1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Syd1,
                "yul1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}