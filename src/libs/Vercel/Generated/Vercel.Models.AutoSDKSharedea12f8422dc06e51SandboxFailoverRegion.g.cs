
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion
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
    public static class AutoSDKSharedea12f8422dc06e51SandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}