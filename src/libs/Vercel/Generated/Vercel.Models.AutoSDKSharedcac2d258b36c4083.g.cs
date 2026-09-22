#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedcac2d258b36c4083 : global::System.IEquatable<AutoSDKSharedcac2d258b36c4083>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? AutoSDKSharedcac2d258b36c4083Variant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? AutoSDKSharedcac2d258b36c4083Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKSharedcac2d258b36c4083Variant1))]
#endif
        public bool IsAutoSDKSharedcac2d258b36c4083Variant1 => AutoSDKSharedcac2d258b36c4083Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKSharedcac2d258b36c4083Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = AutoSDKSharedcac2d258b36c4083Variant1;
            return IsAutoSDKSharedcac2d258b36c4083Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickAutoSDKSharedcac2d258b36c4083Variant1() => IsAutoSDKSharedcac2d258b36c4083Variant1
            ? AutoSDKSharedcac2d258b36c4083Variant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKSharedcac2d258b36c4083Variant1' but the value was {ToString()}.");

        /// <summary>
        /// A rule applied to requests matching a domain in the network policy. Only one of `transform`, `forwardURL`, or `response` can be specified per rule.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>? Sharedad42af066f165baa { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>? Sharedad42af066f165baa { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedad42af066f165baa))]
#endif
        public bool IsSharedad42af066f165baa => Sharedad42af066f165baa != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedad42af066f165baa(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>? value)
        {
            value = Sharedad42af066f165baa;
            return IsSharedad42af066f165baa;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>> PickSharedad42af066f165baa() => IsSharedad42af066f165baa
            ? Sharedad42af066f165baa!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedad42af066f165baa' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedcac2d258b36c4083(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>> value) => new AutoSDKSharedcac2d258b36c4083((global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>?(AutoSDKSharedcac2d258b36c4083 @this) => @this.Sharedad42af066f165baa;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedcac2d258b36c4083(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>? value)
        {
            Sharedad42af066f165baa = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedcac2d258b36c4083 FromSharedad42af066f165baa(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>? value) => new AutoSDKSharedcac2d258b36c4083(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedcac2d258b36c4083(
            global::System.Collections.Generic.IList<string>? autoSDKSharedcac2d258b36c4083Variant1,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>? sharedad42af066f165baa
            )
        {
            AutoSDKSharedcac2d258b36c4083Variant1 = autoSDKSharedcac2d258b36c4083Variant1;
            Sharedad42af066f165baa = sharedad42af066f165baa;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedad42af066f165baa as object ??
            AutoSDKSharedcac2d258b36c4083Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AutoSDKSharedcac2d258b36c4083Variant1?.ToString() ??
            Sharedad42af066f165baa?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAutoSDKSharedcac2d258b36c4083Variant1 && !IsSharedad42af066f165baa || !IsAutoSDKSharedcac2d258b36c4083Variant1 && IsSharedad42af066f165baa;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? autoSDKSharedcac2d258b36c4083Variant1 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>, TResult>? sharedad42af066f165baa = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoSDKSharedcac2d258b36c4083Variant1 && autoSDKSharedcac2d258b36c4083Variant1 != null)
            {
                return autoSDKSharedcac2d258b36c4083Variant1(AutoSDKSharedcac2d258b36c4083Variant1!);
            }
            else if (IsSharedad42af066f165baa && sharedad42af066f165baa != null)
            {
                return sharedad42af066f165baa(Sharedad42af066f165baa!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<string>>? autoSDKSharedcac2d258b36c4083Variant1 = null,

            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>>? sharedad42af066f165baa = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoSDKSharedcac2d258b36c4083Variant1)
            {
                autoSDKSharedcac2d258b36c4083Variant1?.Invoke(AutoSDKSharedcac2d258b36c4083Variant1!);
            }
            else if (IsSharedad42af066f165baa)
            {
                sharedad42af066f165baa?.Invoke(Sharedad42af066f165baa!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<string>>? autoSDKSharedcac2d258b36c4083Variant1 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>>? sharedad42af066f165baa = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoSDKSharedcac2d258b36c4083Variant1)
            {
                autoSDKSharedcac2d258b36c4083Variant1?.Invoke(AutoSDKSharedcac2d258b36c4083Variant1!);
            }
            else if (IsSharedad42af066f165baa)
            {
                sharedad42af066f165baa?.Invoke(Sharedad42af066f165baa!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoSDKSharedcac2d258b36c4083Variant1,
                typeof(global::System.Collections.Generic.IList<string>),
                Sharedad42af066f165baa,
                typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>),
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
        public bool Equals(AutoSDKSharedcac2d258b36c4083 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(AutoSDKSharedcac2d258b36c4083Variant1, other.AutoSDKSharedcac2d258b36c4083Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba1f75615f04b60c>>?>.Default.Equals(Sharedad42af066f165baa, other.Sharedad42af066f165baa)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedcac2d258b36c4083 obj1, AutoSDKSharedcac2d258b36c4083 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedcac2d258b36c4083>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedcac2d258b36c4083 obj1, AutoSDKSharedcac2d258b36c4083 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedcac2d258b36c4083 o && Equals(o);
        }
    }
}
