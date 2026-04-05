#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FlagJSONValue : global::System.IEquatable<FlagJSONValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? FlagJSONValueVariant1 { get; init; }
#else
        public string? FlagJSONValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FlagJSONValueVariant1))]
#endif
        public bool IsFlagJSONValueVariant1 => FlagJSONValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? FlagJSONValueVariant2 { get; init; }
#else
        public double? FlagJSONValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FlagJSONValueVariant2))]
#endif
        public bool IsFlagJSONValueVariant2 => FlagJSONValueVariant2 != null;

        /// <summary>
        /// TODO: The following types will eventually be exported by a more relevant package.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>? FlagJSONValueVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>? FlagJSONValueVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FlagJSONValueVariant3))]
#endif
        public bool IsFlagJSONValueVariant3 => FlagJSONValueVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>? FlagJSONValueVariant4 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>? FlagJSONValueVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FlagJSONValueVariant4))]
#endif
        public bool IsFlagJSONValueVariant4 => FlagJSONValueVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? FlagJSONValueVariant5 { get; init; }
#else
        public bool? FlagJSONValueVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FlagJSONValueVariant5))]
#endif
        public bool IsFlagJSONValueVariant5 => FlagJSONValueVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FlagJSONValue(string value) => new FlagJSONValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(FlagJSONValue @this) => @this.FlagJSONValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public FlagJSONValue(string? value)
        {
            FlagJSONValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FlagJSONValue(double value) => new FlagJSONValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(FlagJSONValue @this) => @this.FlagJSONValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FlagJSONValue(double? value)
        {
            FlagJSONValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FlagJSONValue(global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?> value) => new FlagJSONValue((global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>?(FlagJSONValue @this) => @this.FlagJSONValueVariant4;

        /// <summary>
        /// 
        /// </summary>
        public FlagJSONValue(global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>? value)
        {
            FlagJSONValueVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FlagJSONValue(bool value) => new FlagJSONValue((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(FlagJSONValue @this) => @this.FlagJSONValueVariant5;

        /// <summary>
        /// 
        /// </summary>
        public FlagJSONValue(bool? value)
        {
            FlagJSONValueVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FlagJSONValue(
            string? flagJSONValueVariant1,
            double? flagJSONValueVariant2,
            global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>? flagJSONValueVariant3,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>? flagJSONValueVariant4,
            bool? flagJSONValueVariant5
            )
        {
            FlagJSONValueVariant1 = flagJSONValueVariant1;
            FlagJSONValueVariant2 = flagJSONValueVariant2;
            FlagJSONValueVariant3 = flagJSONValueVariant3;
            FlagJSONValueVariant4 = flagJSONValueVariant4;
            FlagJSONValueVariant5 = flagJSONValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FlagJSONValueVariant5 as object ??
            FlagJSONValueVariant4 as object ??
            FlagJSONValueVariant3 as object ??
            FlagJSONValueVariant2 as object ??
            FlagJSONValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FlagJSONValueVariant1?.ToString() ??
            FlagJSONValueVariant2?.ToString() ??
            FlagJSONValueVariant3?.ToString() ??
            FlagJSONValueVariant4?.ToString() ??
            FlagJSONValueVariant5?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFlagJSONValueVariant1 && !IsFlagJSONValueVariant2 && !IsFlagJSONValueVariant3 && !IsFlagJSONValueVariant4 && !IsFlagJSONValueVariant5 || !IsFlagJSONValueVariant1 && IsFlagJSONValueVariant2 && !IsFlagJSONValueVariant3 && !IsFlagJSONValueVariant4 && !IsFlagJSONValueVariant5 || !IsFlagJSONValueVariant1 && !IsFlagJSONValueVariant2 && IsFlagJSONValueVariant3 && !IsFlagJSONValueVariant4 && !IsFlagJSONValueVariant5 || !IsFlagJSONValueVariant1 && !IsFlagJSONValueVariant2 && !IsFlagJSONValueVariant3 && IsFlagJSONValueVariant4 && !IsFlagJSONValueVariant5 || !IsFlagJSONValueVariant1 && !IsFlagJSONValueVariant2 && !IsFlagJSONValueVariant3 && !IsFlagJSONValueVariant4 && IsFlagJSONValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? flagJSONValueVariant1 = null,
            global::System.Func<double?, TResult>? flagJSONValueVariant2 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>?, TResult>? flagJSONValueVariant3 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>?, TResult>? flagJSONValueVariant4 = null,
            global::System.Func<bool?, TResult>? flagJSONValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFlagJSONValueVariant1 && flagJSONValueVariant1 != null)
            {
                return flagJSONValueVariant1(FlagJSONValueVariant1!);
            }
            else if (IsFlagJSONValueVariant2 && flagJSONValueVariant2 != null)
            {
                return flagJSONValueVariant2(FlagJSONValueVariant2!);
            }
            else if (IsFlagJSONValueVariant3 && flagJSONValueVariant3 != null)
            {
                return flagJSONValueVariant3(FlagJSONValueVariant3!);
            }
            else if (IsFlagJSONValueVariant4 && flagJSONValueVariant4 != null)
            {
                return flagJSONValueVariant4(FlagJSONValueVariant4!);
            }
            else if (IsFlagJSONValueVariant5 && flagJSONValueVariant5 != null)
            {
                return flagJSONValueVariant5(FlagJSONValueVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? flagJSONValueVariant1 = null,
            global::System.Action<double?>? flagJSONValueVariant2 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>?>? flagJSONValueVariant3 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>?>? flagJSONValueVariant4 = null,
            global::System.Action<bool?>? flagJSONValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFlagJSONValueVariant1)
            {
                flagJSONValueVariant1?.Invoke(FlagJSONValueVariant1!);
            }
            else if (IsFlagJSONValueVariant2)
            {
                flagJSONValueVariant2?.Invoke(FlagJSONValueVariant2!);
            }
            else if (IsFlagJSONValueVariant3)
            {
                flagJSONValueVariant3?.Invoke(FlagJSONValueVariant3!);
            }
            else if (IsFlagJSONValueVariant4)
            {
                flagJSONValueVariant4?.Invoke(FlagJSONValueVariant4!);
            }
            else if (IsFlagJSONValueVariant5)
            {
                flagJSONValueVariant5?.Invoke(FlagJSONValueVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FlagJSONValueVariant1,
                typeof(string),
                FlagJSONValueVariant2,
                typeof(double),
                FlagJSONValueVariant3,
                typeof(global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>),
                FlagJSONValueVariant4,
                typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>),
                FlagJSONValueVariant5,
                typeof(bool),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(FlagJSONValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(FlagJSONValueVariant1, other.FlagJSONValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(FlagJSONValueVariant2, other.FlagJSONValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>?>.Default.Equals(FlagJSONValueVariant3, other.FlagJSONValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>?>.Default.Equals(FlagJSONValueVariant4, other.FlagJSONValueVariant4) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(FlagJSONValueVariant5, other.FlagJSONValueVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FlagJSONValue obj1, FlagJSONValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FlagJSONValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FlagJSONValue obj1, FlagJSONValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FlagJSONValue o && Equals(o);
        }
    }
}
