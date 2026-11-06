
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda2d284b091a73479SandboxFailoverRegion
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
    public static class AutoSDKShareda2d284b091a73479SandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda2d284b091a73479SandboxFailoverRegion value)
        {
            return value switch
            {
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Arn1 => "arn1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Bom1 => "bom1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Cdg1 => "cdg1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Cle1 => "cle1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Cpt1 => "cpt1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Dub1 => "dub1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Fra1 => "fra1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Gru1 => "gru1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Hkg1 => "hkg1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Hnd1 => "hnd1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Iad1 => "iad1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Icn1 => "icn1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Kix1 => "kix1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Lhr1 => "lhr1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Pdx1 => "pdx1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Sfo1 => "sfo1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Sin1 => "sin1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Syd1 => "syd1",
                AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda2d284b091a73479SandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Arn1,
                "bom1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Bom1,
                "cdg1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Cdg1,
                "cle1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Cle1,
                "cpt1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Cpt1,
                "dub1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Dub1,
                "fra1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Fra1,
                "gru1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Gru1,
                "hkg1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Hkg1,
                "hnd1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Hnd1,
                "iad1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Iad1,
                "icn1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Icn1,
                "kix1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Kix1,
                "lhr1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Lhr1,
                "pdx1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Pdx1,
                "sfo1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Sfo1,
                "sin1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Sin1,
                "syd1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Syd1,
                "yul1" => AutoSDKShareda2d284b091a73479SandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}