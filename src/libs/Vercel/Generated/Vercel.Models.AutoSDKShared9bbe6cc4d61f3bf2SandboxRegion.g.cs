
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2SandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Arn1 => "arn1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Bom1 => "bom1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Cdg1 => "cdg1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Cle1 => "cle1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Cpt1 => "cpt1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Dub1 => "dub1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Fra1 => "fra1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Gru1 => "gru1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Hkg1 => "hkg1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Hnd1 => "hnd1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Iad1 => "iad1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Icn1 => "icn1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Kix1 => "kix1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Lhr1 => "lhr1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Pdx1 => "pdx1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Sfo1 => "sfo1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Sin1 => "sin1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Syd1 => "syd1",
                AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Arn1,
                "bom1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Bom1,
                "cdg1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Cdg1,
                "cle1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Cle1,
                "cpt1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Cpt1,
                "dub1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Dub1,
                "fra1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Fra1,
                "gru1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Gru1,
                "hkg1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Hkg1,
                "hnd1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Hnd1,
                "iad1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Iad1,
                "icn1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Icn1,
                "kix1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Kix1,
                "lhr1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Lhr1,
                "pdx1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Pdx1,
                "sfo1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Sfo1,
                "sin1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Sin1,
                "syd1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Syd1,
                "yul1" => AutoSDKShared9bbe6cc4d61f3bf2SandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}