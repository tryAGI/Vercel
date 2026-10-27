
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion
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
    public static class AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKSharedbe3f0c688bc34a31SandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}