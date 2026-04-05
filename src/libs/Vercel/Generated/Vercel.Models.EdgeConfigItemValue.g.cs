#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EdgeConfigItemValue : global::System.IEquatable<EdgeConfigItemValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? EdgeConfigItemValueVariant1 { get; init; }
#else
        public string? EdgeConfigItemValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EdgeConfigItemValueVariant1))]
#endif
        public bool IsEdgeConfigItemValueVariant1 => EdgeConfigItemValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? EdgeConfigItemValueVariant2 { get; init; }
#else
        public double? EdgeConfigItemValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EdgeConfigItemValueVariant2))]
#endif
        public bool IsEdgeConfigItemValueVariant2 => EdgeConfigItemValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>? EdgeConfigItemValueVariant3 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>? EdgeConfigItemValueVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EdgeConfigItemValueVariant3))]
#endif
        public bool IsEdgeConfigItemValueVariant3 => EdgeConfigItemValueVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>? EdgeConfigItemValueVariant4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>? EdgeConfigItemValueVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EdgeConfigItemValueVariant4))]
#endif
        public bool IsEdgeConfigItemValueVariant4 => EdgeConfigItemValueVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? EdgeConfigItemValueVariant5 { get; init; }
#else
        public bool? EdgeConfigItemValueVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EdgeConfigItemValueVariant5))]
#endif
        public bool IsEdgeConfigItemValueVariant5 => EdgeConfigItemValueVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EdgeConfigItemValue(string value) => new EdgeConfigItemValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EdgeConfigItemValue @this) => @this.EdgeConfigItemValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public EdgeConfigItemValue(string? value)
        {
            EdgeConfigItemValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EdgeConfigItemValue(double value) => new EdgeConfigItemValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(EdgeConfigItemValue @this) => @this.EdgeConfigItemValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EdgeConfigItemValue(double? value)
        {
            EdgeConfigItemValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EdgeConfigItemValue(global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?> value) => new EdgeConfigItemValue((global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>?(EdgeConfigItemValue @this) => @this.EdgeConfigItemValueVariant3;

        /// <summary>
        /// 
        /// </summary>
        public EdgeConfigItemValue(global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>? value)
        {
            EdgeConfigItemValueVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EdgeConfigItemValue(bool value) => new EdgeConfigItemValue((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(EdgeConfigItemValue @this) => @this.EdgeConfigItemValueVariant5;

        /// <summary>
        /// 
        /// </summary>
        public EdgeConfigItemValue(bool? value)
        {
            EdgeConfigItemValueVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EdgeConfigItemValue(
            string? edgeConfigItemValueVariant1,
            double? edgeConfigItemValueVariant2,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>? edgeConfigItemValueVariant3,
            global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>? edgeConfigItemValueVariant4,
            bool? edgeConfigItemValueVariant5
            )
        {
            EdgeConfigItemValueVariant1 = edgeConfigItemValueVariant1;
            EdgeConfigItemValueVariant2 = edgeConfigItemValueVariant2;
            EdgeConfigItemValueVariant3 = edgeConfigItemValueVariant3;
            EdgeConfigItemValueVariant4 = edgeConfigItemValueVariant4;
            EdgeConfigItemValueVariant5 = edgeConfigItemValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EdgeConfigItemValueVariant5 as object ??
            EdgeConfigItemValueVariant4 as object ??
            EdgeConfigItemValueVariant3 as object ??
            EdgeConfigItemValueVariant2 as object ??
            EdgeConfigItemValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EdgeConfigItemValueVariant1?.ToString() ??
            EdgeConfigItemValueVariant2?.ToString() ??
            EdgeConfigItemValueVariant3?.ToString() ??
            EdgeConfigItemValueVariant4?.ToString() ??
            EdgeConfigItemValueVariant5?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEdgeConfigItemValueVariant1 && !IsEdgeConfigItemValueVariant2 && !IsEdgeConfigItemValueVariant3 && !IsEdgeConfigItemValueVariant4 && !IsEdgeConfigItemValueVariant5 || !IsEdgeConfigItemValueVariant1 && IsEdgeConfigItemValueVariant2 && !IsEdgeConfigItemValueVariant3 && !IsEdgeConfigItemValueVariant4 && !IsEdgeConfigItemValueVariant5 || !IsEdgeConfigItemValueVariant1 && !IsEdgeConfigItemValueVariant2 && IsEdgeConfigItemValueVariant3 && !IsEdgeConfigItemValueVariant4 && !IsEdgeConfigItemValueVariant5 || !IsEdgeConfigItemValueVariant1 && !IsEdgeConfigItemValueVariant2 && !IsEdgeConfigItemValueVariant3 && IsEdgeConfigItemValueVariant4 && !IsEdgeConfigItemValueVariant5 || !IsEdgeConfigItemValueVariant1 && !IsEdgeConfigItemValueVariant2 && !IsEdgeConfigItemValueVariant3 && !IsEdgeConfigItemValueVariant4 && IsEdgeConfigItemValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? edgeConfigItemValueVariant1 = null,
            global::System.Func<double?, TResult>? edgeConfigItemValueVariant2 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>?, TResult>? edgeConfigItemValueVariant3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>?, TResult>? edgeConfigItemValueVariant4 = null,
            global::System.Func<bool?, TResult>? edgeConfigItemValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEdgeConfigItemValueVariant1 && edgeConfigItemValueVariant1 != null)
            {
                return edgeConfigItemValueVariant1(EdgeConfigItemValueVariant1!);
            }
            else if (IsEdgeConfigItemValueVariant2 && edgeConfigItemValueVariant2 != null)
            {
                return edgeConfigItemValueVariant2(EdgeConfigItemValueVariant2!);
            }
            else if (IsEdgeConfigItemValueVariant3 && edgeConfigItemValueVariant3 != null)
            {
                return edgeConfigItemValueVariant3(EdgeConfigItemValueVariant3!);
            }
            else if (IsEdgeConfigItemValueVariant4 && edgeConfigItemValueVariant4 != null)
            {
                return edgeConfigItemValueVariant4(EdgeConfigItemValueVariant4!);
            }
            else if (IsEdgeConfigItemValueVariant5 && edgeConfigItemValueVariant5 != null)
            {
                return edgeConfigItemValueVariant5(EdgeConfigItemValueVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? edgeConfigItemValueVariant1 = null,
            global::System.Action<double?>? edgeConfigItemValueVariant2 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>?>? edgeConfigItemValueVariant3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>?>? edgeConfigItemValueVariant4 = null,
            global::System.Action<bool?>? edgeConfigItemValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEdgeConfigItemValueVariant1)
            {
                edgeConfigItemValueVariant1?.Invoke(EdgeConfigItemValueVariant1!);
            }
            else if (IsEdgeConfigItemValueVariant2)
            {
                edgeConfigItemValueVariant2?.Invoke(EdgeConfigItemValueVariant2!);
            }
            else if (IsEdgeConfigItemValueVariant3)
            {
                edgeConfigItemValueVariant3?.Invoke(EdgeConfigItemValueVariant3!);
            }
            else if (IsEdgeConfigItemValueVariant4)
            {
                edgeConfigItemValueVariant4?.Invoke(EdgeConfigItemValueVariant4!);
            }
            else if (IsEdgeConfigItemValueVariant5)
            {
                edgeConfigItemValueVariant5?.Invoke(EdgeConfigItemValueVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EdgeConfigItemValueVariant1,
                typeof(string),
                EdgeConfigItemValueVariant2,
                typeof(double),
                EdgeConfigItemValueVariant3,
                typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>),
                EdgeConfigItemValueVariant4,
                typeof(global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>),
                EdgeConfigItemValueVariant5,
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
        public bool Equals(EdgeConfigItemValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EdgeConfigItemValueVariant1, other.EdgeConfigItemValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(EdgeConfigItemValueVariant2, other.EdgeConfigItemValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>?>.Default.Equals(EdgeConfigItemValueVariant3, other.EdgeConfigItemValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>?>.Default.Equals(EdgeConfigItemValueVariant4, other.EdgeConfigItemValueVariant4) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(EdgeConfigItemValueVariant5, other.EdgeConfigItemValueVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EdgeConfigItemValue obj1, EdgeConfigItemValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EdgeConfigItemValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EdgeConfigItemValue obj1, EdgeConfigItemValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EdgeConfigItemValue o && Equals(o);
        }
    }
}
