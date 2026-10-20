
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion
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
    public static class AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKSharedd9ba619caaa0a759SandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}