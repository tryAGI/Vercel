#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GlobalConfigItemValue : global::System.IEquatable<GlobalConfigItemValue>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? GlobalConfigItemValueVariant1 { get; init; }
#else
        public string? GlobalConfigItemValueVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GlobalConfigItemValueVariant1))]
#endif
        public bool IsGlobalConfigItemValueVariant1 => GlobalConfigItemValueVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGlobalConfigItemValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = GlobalConfigItemValueVariant1;
            return IsGlobalConfigItemValueVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickGlobalConfigItemValueVariant1() => IsGlobalConfigItemValueVariant1
            ? GlobalConfigItemValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GlobalConfigItemValueVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? GlobalConfigItemValueVariant2 { get; init; }
#else
        public double? GlobalConfigItemValueVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GlobalConfigItemValueVariant2))]
#endif
        public bool IsGlobalConfigItemValueVariant2 => GlobalConfigItemValueVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGlobalConfigItemValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = GlobalConfigItemValueVariant2;
            return IsGlobalConfigItemValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickGlobalConfigItemValueVariant2() => IsGlobalConfigItemValueVariant2
            ? GlobalConfigItemValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GlobalConfigItemValueVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>? GlobalConfigItemValueVariant3 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>? GlobalConfigItemValueVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GlobalConfigItemValueVariant3))]
#endif
        public bool IsGlobalConfigItemValueVariant3 => GlobalConfigItemValueVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGlobalConfigItemValueVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>? value)
        {
            value = GlobalConfigItemValueVariant3;
            return IsGlobalConfigItemValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?> PickGlobalConfigItemValueVariant3() => IsGlobalConfigItemValueVariant3
            ? GlobalConfigItemValueVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GlobalConfigItemValueVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>? GlobalConfigItemValueVariant4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>? GlobalConfigItemValueVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GlobalConfigItemValueVariant4))]
#endif
        public bool IsGlobalConfigItemValueVariant4 => GlobalConfigItemValueVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGlobalConfigItemValueVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>? value)
        {
            value = GlobalConfigItemValueVariant4;
            return IsGlobalConfigItemValueVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue> PickGlobalConfigItemValueVariant4() => IsGlobalConfigItemValueVariant4
            ? GlobalConfigItemValueVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GlobalConfigItemValueVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? GlobalConfigItemValueVariant5 { get; init; }
#else
        public bool? GlobalConfigItemValueVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GlobalConfigItemValueVariant5))]
#endif
        public bool IsGlobalConfigItemValueVariant5 => GlobalConfigItemValueVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGlobalConfigItemValueVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = GlobalConfigItemValueVariant5;
            return IsGlobalConfigItemValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickGlobalConfigItemValueVariant5() => IsGlobalConfigItemValueVariant5
            ? GlobalConfigItemValueVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GlobalConfigItemValueVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GlobalConfigItemValue(string value) => new GlobalConfigItemValue((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(GlobalConfigItemValue @this) => @this.GlobalConfigItemValueVariant1;

        /// <summary>
        ///
        /// </summary>
        public GlobalConfigItemValue(string? value)
        {
            GlobalConfigItemValueVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GlobalConfigItemValue FromGlobalConfigItemValueVariant1(string? value) => new GlobalConfigItemValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GlobalConfigItemValue(double value) => new GlobalConfigItemValue((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(GlobalConfigItemValue @this) => @this.GlobalConfigItemValueVariant2;

        /// <summary>
        ///
        /// </summary>
        public GlobalConfigItemValue(double? value)
        {
            GlobalConfigItemValueVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GlobalConfigItemValue FromGlobalConfigItemValueVariant2(double? value) => new GlobalConfigItemValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GlobalConfigItemValue(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?> value) => new GlobalConfigItemValue((global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>?(GlobalConfigItemValue @this) => @this.GlobalConfigItemValueVariant3;

        /// <summary>
        ///
        /// </summary>
        public GlobalConfigItemValue(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>? value)
        {
            GlobalConfigItemValueVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GlobalConfigItemValue FromGlobalConfigItemValueVariant3(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>? value) => new GlobalConfigItemValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GlobalConfigItemValue(bool value) => new GlobalConfigItemValue((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(GlobalConfigItemValue @this) => @this.GlobalConfigItemValueVariant5;

        /// <summary>
        ///
        /// </summary>
        public GlobalConfigItemValue(bool? value)
        {
            GlobalConfigItemValueVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GlobalConfigItemValue FromGlobalConfigItemValueVariant5(bool? value) => new GlobalConfigItemValue(value);

        /// <summary>
        ///
        /// </summary>
        public GlobalConfigItemValue(
            string? globalConfigItemValueVariant1,
            double? globalConfigItemValueVariant2,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>? globalConfigItemValueVariant3,
            global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>? globalConfigItemValueVariant4,
            bool? globalConfigItemValueVariant5
            )
        {
            GlobalConfigItemValueVariant1 = globalConfigItemValueVariant1;
            GlobalConfigItemValueVariant2 = globalConfigItemValueVariant2;
            GlobalConfigItemValueVariant3 = globalConfigItemValueVariant3;
            GlobalConfigItemValueVariant4 = globalConfigItemValueVariant4;
            GlobalConfigItemValueVariant5 = globalConfigItemValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GlobalConfigItemValueVariant5 as object ??
            GlobalConfigItemValueVariant4 as object ??
            GlobalConfigItemValueVariant3 as object ??
            GlobalConfigItemValueVariant2 as object ??
            GlobalConfigItemValueVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GlobalConfigItemValueVariant1?.ToString() ??
            GlobalConfigItemValueVariant2?.ToString() ??
            GlobalConfigItemValueVariant3?.ToString() ??
            GlobalConfigItemValueVariant4?.ToString() ??
            GlobalConfigItemValueVariant5?.ToString().ToLowerInvariant()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGlobalConfigItemValueVariant1 && !IsGlobalConfigItemValueVariant2 && !IsGlobalConfigItemValueVariant3 && !IsGlobalConfigItemValueVariant4 && !IsGlobalConfigItemValueVariant5 || !IsGlobalConfigItemValueVariant1 && IsGlobalConfigItemValueVariant2 && !IsGlobalConfigItemValueVariant3 && !IsGlobalConfigItemValueVariant4 && !IsGlobalConfigItemValueVariant5 || !IsGlobalConfigItemValueVariant1 && !IsGlobalConfigItemValueVariant2 && IsGlobalConfigItemValueVariant3 && !IsGlobalConfigItemValueVariant4 && !IsGlobalConfigItemValueVariant5 || !IsGlobalConfigItemValueVariant1 && !IsGlobalConfigItemValueVariant2 && !IsGlobalConfigItemValueVariant3 && IsGlobalConfigItemValueVariant4 && !IsGlobalConfigItemValueVariant5 || !IsGlobalConfigItemValueVariant1 && !IsGlobalConfigItemValueVariant2 && !IsGlobalConfigItemValueVariant3 && !IsGlobalConfigItemValueVariant4 && IsGlobalConfigItemValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? globalConfigItemValueVariant1 = null,
            global::System.Func<double?, TResult>? globalConfigItemValueVariant2 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>, TResult>? globalConfigItemValueVariant3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>, TResult>? globalConfigItemValueVariant4 = null,
            global::System.Func<bool?, TResult>? globalConfigItemValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGlobalConfigItemValueVariant1 && globalConfigItemValueVariant1 != null)
            {
                return globalConfigItemValueVariant1(GlobalConfigItemValueVariant1!);
            }
            else if (IsGlobalConfigItemValueVariant2 && globalConfigItemValueVariant2 != null)
            {
                return globalConfigItemValueVariant2(GlobalConfigItemValueVariant2!);
            }
            else if (IsGlobalConfigItemValueVariant3 && globalConfigItemValueVariant3 != null)
            {
                return globalConfigItemValueVariant3(GlobalConfigItemValueVariant3!);
            }
            else if (IsGlobalConfigItemValueVariant4 && globalConfigItemValueVariant4 != null)
            {
                return globalConfigItemValueVariant4(GlobalConfigItemValueVariant4!);
            }
            else if (IsGlobalConfigItemValueVariant5 && globalConfigItemValueVariant5 != null)
            {
                return globalConfigItemValueVariant5(GlobalConfigItemValueVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? globalConfigItemValueVariant1 = null,

            global::System.Action<double?>? globalConfigItemValueVariant2 = null,

            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>>? globalConfigItemValueVariant3 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>>? globalConfigItemValueVariant4 = null,

            global::System.Action<bool?>? globalConfigItemValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGlobalConfigItemValueVariant1)
            {
                globalConfigItemValueVariant1?.Invoke(GlobalConfigItemValueVariant1!);
            }
            else if (IsGlobalConfigItemValueVariant2)
            {
                globalConfigItemValueVariant2?.Invoke(GlobalConfigItemValueVariant2!);
            }
            else if (IsGlobalConfigItemValueVariant3)
            {
                globalConfigItemValueVariant3?.Invoke(GlobalConfigItemValueVariant3!);
            }
            else if (IsGlobalConfigItemValueVariant4)
            {
                globalConfigItemValueVariant4?.Invoke(GlobalConfigItemValueVariant4!);
            }
            else if (IsGlobalConfigItemValueVariant5)
            {
                globalConfigItemValueVariant5?.Invoke(GlobalConfigItemValueVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? globalConfigItemValueVariant1 = null,
            global::System.Action<double?>? globalConfigItemValueVariant2 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>>? globalConfigItemValueVariant3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>>? globalConfigItemValueVariant4 = null,
            global::System.Action<bool?>? globalConfigItemValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGlobalConfigItemValueVariant1)
            {
                globalConfigItemValueVariant1?.Invoke(GlobalConfigItemValueVariant1!);
            }
            else if (IsGlobalConfigItemValueVariant2)
            {
                globalConfigItemValueVariant2?.Invoke(GlobalConfigItemValueVariant2!);
            }
            else if (IsGlobalConfigItemValueVariant3)
            {
                globalConfigItemValueVariant3?.Invoke(GlobalConfigItemValueVariant3!);
            }
            else if (IsGlobalConfigItemValueVariant4)
            {
                globalConfigItemValueVariant4?.Invoke(GlobalConfigItemValueVariant4!);
            }
            else if (IsGlobalConfigItemValueVariant5)
            {
                globalConfigItemValueVariant5?.Invoke(GlobalConfigItemValueVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GlobalConfigItemValueVariant1,
                typeof(string),
                GlobalConfigItemValueVariant2,
                typeof(double),
                GlobalConfigItemValueVariant3,
                typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>),
                GlobalConfigItemValueVariant4,
                typeof(global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>),
                GlobalConfigItemValueVariant5,
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
        public bool Equals(GlobalConfigItemValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(GlobalConfigItemValueVariant1, other.GlobalConfigItemValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(GlobalConfigItemValueVariant2, other.GlobalConfigItemValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>?>.Default.Equals(GlobalConfigItemValueVariant3, other.GlobalConfigItemValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue>?>.Default.Equals(GlobalConfigItemValueVariant4, other.GlobalConfigItemValueVariant4) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(GlobalConfigItemValueVariant5, other.GlobalConfigItemValueVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GlobalConfigItemValue obj1, GlobalConfigItemValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GlobalConfigItemValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GlobalConfigItemValue obj1, GlobalConfigItemValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GlobalConfigItemValue o && Equals(o);
        }
    }
}
