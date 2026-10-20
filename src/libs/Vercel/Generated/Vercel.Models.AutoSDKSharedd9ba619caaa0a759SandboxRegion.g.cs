
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759SandboxRegion
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
    public static class AutoSDKSharedd9ba619caaa0a759SandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759SandboxRegion value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Arn1 => "arn1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Bom1 => "bom1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Cdg1 => "cdg1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Cle1 => "cle1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Cpt1 => "cpt1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Dub1 => "dub1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Fra1 => "fra1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Gru1 => "gru1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Hkg1 => "hkg1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Hnd1 => "hnd1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Iad1 => "iad1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Icn1 => "icn1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Kix1 => "kix1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Lhr1 => "lhr1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Pdx1 => "pdx1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Sfo1 => "sfo1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Sin1 => "sin1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Syd1 => "syd1",
                AutoSDKSharedd9ba619caaa0a759SandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759SandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Arn1,
                "bom1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Bom1,
                "cdg1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Cdg1,
                "cle1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Cle1,
                "cpt1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Cpt1,
                "dub1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Dub1,
                "fra1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Fra1,
                "gru1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Gru1,
                "hkg1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Hkg1,
                "hnd1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Hnd1,
                "iad1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Iad1,
                "icn1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Icn1,
                "kix1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Kix1,
                "lhr1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Lhr1,
                "pdx1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Pdx1,
                "sfo1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Sfo1,
                "sin1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Sin1,
                "syd1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Syd1,
                "yul1" => AutoSDKSharedd9ba619caaa0a759SandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}