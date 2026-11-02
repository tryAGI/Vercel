
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf5934c240f4382f7SandboxRegion
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
    public static class AutoSDKSharedf5934c240f4382f7SandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf5934c240f4382f7SandboxRegion value)
        {
            return value switch
            {
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Arn1 => "arn1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Bom1 => "bom1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Cdg1 => "cdg1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Cle1 => "cle1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Cpt1 => "cpt1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Dub1 => "dub1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Fra1 => "fra1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Gru1 => "gru1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Hkg1 => "hkg1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Hnd1 => "hnd1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Iad1 => "iad1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Icn1 => "icn1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Kix1 => "kix1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Lhr1 => "lhr1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Pdx1 => "pdx1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Sfo1 => "sfo1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Sin1 => "sin1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Syd1 => "syd1",
                AutoSDKSharedf5934c240f4382f7SandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf5934c240f4382f7SandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Arn1,
                "bom1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Bom1,
                "cdg1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Cdg1,
                "cle1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Cle1,
                "cpt1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Cpt1,
                "dub1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Dub1,
                "fra1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Fra1,
                "gru1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Gru1,
                "hkg1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Hkg1,
                "hnd1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Hnd1,
                "iad1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Iad1,
                "icn1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Icn1,
                "kix1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Kix1,
                "lhr1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Lhr1,
                "pdx1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Pdx1,
                "sfo1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Sfo1,
                "sin1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Sin1,
                "syd1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Syd1,
                "yul1" => AutoSDKSharedf5934c240f4382f7SandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}