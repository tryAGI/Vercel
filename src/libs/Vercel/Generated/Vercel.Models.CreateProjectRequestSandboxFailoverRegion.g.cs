
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectRequestSandboxFailoverRegion
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
    public static class CreateProjectRequestSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestSandboxFailoverRegion value)
        {
            return value switch
            {
                CreateProjectRequestSandboxFailoverRegion.Arn1 => "arn1",
                CreateProjectRequestSandboxFailoverRegion.Bom1 => "bom1",
                CreateProjectRequestSandboxFailoverRegion.Cdg1 => "cdg1",
                CreateProjectRequestSandboxFailoverRegion.Cle1 => "cle1",
                CreateProjectRequestSandboxFailoverRegion.Cpt1 => "cpt1",
                CreateProjectRequestSandboxFailoverRegion.Dub1 => "dub1",
                CreateProjectRequestSandboxFailoverRegion.Fra1 => "fra1",
                CreateProjectRequestSandboxFailoverRegion.Gru1 => "gru1",
                CreateProjectRequestSandboxFailoverRegion.Hkg1 => "hkg1",
                CreateProjectRequestSandboxFailoverRegion.Hnd1 => "hnd1",
                CreateProjectRequestSandboxFailoverRegion.Iad1 => "iad1",
                CreateProjectRequestSandboxFailoverRegion.Icn1 => "icn1",
                CreateProjectRequestSandboxFailoverRegion.Kix1 => "kix1",
                CreateProjectRequestSandboxFailoverRegion.Lhr1 => "lhr1",
                CreateProjectRequestSandboxFailoverRegion.Pdx1 => "pdx1",
                CreateProjectRequestSandboxFailoverRegion.Sfo1 => "sfo1",
                CreateProjectRequestSandboxFailoverRegion.Sin1 => "sin1",
                CreateProjectRequestSandboxFailoverRegion.Syd1 => "syd1",
                CreateProjectRequestSandboxFailoverRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => CreateProjectRequestSandboxFailoverRegion.Arn1,
                "bom1" => CreateProjectRequestSandboxFailoverRegion.Bom1,
                "cdg1" => CreateProjectRequestSandboxFailoverRegion.Cdg1,
                "cle1" => CreateProjectRequestSandboxFailoverRegion.Cle1,
                "cpt1" => CreateProjectRequestSandboxFailoverRegion.Cpt1,
                "dub1" => CreateProjectRequestSandboxFailoverRegion.Dub1,
                "fra1" => CreateProjectRequestSandboxFailoverRegion.Fra1,
                "gru1" => CreateProjectRequestSandboxFailoverRegion.Gru1,
                "hkg1" => CreateProjectRequestSandboxFailoverRegion.Hkg1,
                "hnd1" => CreateProjectRequestSandboxFailoverRegion.Hnd1,
                "iad1" => CreateProjectRequestSandboxFailoverRegion.Iad1,
                "icn1" => CreateProjectRequestSandboxFailoverRegion.Icn1,
                "kix1" => CreateProjectRequestSandboxFailoverRegion.Kix1,
                "lhr1" => CreateProjectRequestSandboxFailoverRegion.Lhr1,
                "pdx1" => CreateProjectRequestSandboxFailoverRegion.Pdx1,
                "sfo1" => CreateProjectRequestSandboxFailoverRegion.Sfo1,
                "sin1" => CreateProjectRequestSandboxFailoverRegion.Sin1,
                "syd1" => CreateProjectRequestSandboxFailoverRegion.Syd1,
                "yul1" => CreateProjectRequestSandboxFailoverRegion.Yul1,
                _ => null,
            };
        }
    }
}