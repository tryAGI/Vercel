
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7851faacb4798d73SandboxRegion
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
    public static class AutoSDKShared7851faacb4798d73SandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7851faacb4798d73SandboxRegion value)
        {
            return value switch
            {
                AutoSDKShared7851faacb4798d73SandboxRegion.Arn1 => "arn1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Bom1 => "bom1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Cdg1 => "cdg1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Cle1 => "cle1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Cpt1 => "cpt1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Dub1 => "dub1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Fra1 => "fra1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Gru1 => "gru1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Hkg1 => "hkg1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Hnd1 => "hnd1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Iad1 => "iad1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Icn1 => "icn1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Kix1 => "kix1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Lhr1 => "lhr1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Pdx1 => "pdx1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Sfo1 => "sfo1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Sin1 => "sin1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Syd1 => "syd1",
                AutoSDKShared7851faacb4798d73SandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7851faacb4798d73SandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShared7851faacb4798d73SandboxRegion.Arn1,
                "bom1" => AutoSDKShared7851faacb4798d73SandboxRegion.Bom1,
                "cdg1" => AutoSDKShared7851faacb4798d73SandboxRegion.Cdg1,
                "cle1" => AutoSDKShared7851faacb4798d73SandboxRegion.Cle1,
                "cpt1" => AutoSDKShared7851faacb4798d73SandboxRegion.Cpt1,
                "dub1" => AutoSDKShared7851faacb4798d73SandboxRegion.Dub1,
                "fra1" => AutoSDKShared7851faacb4798d73SandboxRegion.Fra1,
                "gru1" => AutoSDKShared7851faacb4798d73SandboxRegion.Gru1,
                "hkg1" => AutoSDKShared7851faacb4798d73SandboxRegion.Hkg1,
                "hnd1" => AutoSDKShared7851faacb4798d73SandboxRegion.Hnd1,
                "iad1" => AutoSDKShared7851faacb4798d73SandboxRegion.Iad1,
                "icn1" => AutoSDKShared7851faacb4798d73SandboxRegion.Icn1,
                "kix1" => AutoSDKShared7851faacb4798d73SandboxRegion.Kix1,
                "lhr1" => AutoSDKShared7851faacb4798d73SandboxRegion.Lhr1,
                "pdx1" => AutoSDKShared7851faacb4798d73SandboxRegion.Pdx1,
                "sfo1" => AutoSDKShared7851faacb4798d73SandboxRegion.Sfo1,
                "sin1" => AutoSDKShared7851faacb4798d73SandboxRegion.Sin1,
                "syd1" => AutoSDKShared7851faacb4798d73SandboxRegion.Syd1,
                "yul1" => AutoSDKShared7851faacb4798d73SandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}