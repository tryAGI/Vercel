
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion
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
    public static class AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKSharedfa8b687d5ac48c48SandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}