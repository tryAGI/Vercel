#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct VcrImageLayer : global::System.IEquatable<VcrImageLayer>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.VcrImageLayerVariant1? VcrImageLayerVariant1 { get; init; }
#else
        public global::Vercel.VcrImageLayerVariant1? VcrImageLayerVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VcrImageLayerVariant1))]
#endif
        public bool IsVcrImageLayerVariant1 => VcrImageLayerVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVcrImageLayerVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.VcrImageLayerVariant1? value)
        {
            value = VcrImageLayerVariant1;
            return IsVcrImageLayerVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.VcrImageLayerVariant1 PickVcrImageLayerVariant1() => IsVcrImageLayerVariant1
            ? VcrImageLayerVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VcrImageLayerVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.VcrImageLayerVariant2? VcrImageLayerVariant2 { get; init; }
#else
        public global::Vercel.VcrImageLayerVariant2? VcrImageLayerVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VcrImageLayerVariant2))]
#endif
        public bool IsVcrImageLayerVariant2 => VcrImageLayerVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVcrImageLayerVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.VcrImageLayerVariant2? value)
        {
            value = VcrImageLayerVariant2;
            return IsVcrImageLayerVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.VcrImageLayerVariant2 PickVcrImageLayerVariant2() => IsVcrImageLayerVariant2
            ? VcrImageLayerVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VcrImageLayerVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.VcrImageLayerVariant3? VcrImageLayerVariant3 { get; init; }
#else
        public global::Vercel.VcrImageLayerVariant3? VcrImageLayerVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VcrImageLayerVariant3))]
#endif
        public bool IsVcrImageLayerVariant3 => VcrImageLayerVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVcrImageLayerVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.VcrImageLayerVariant3? value)
        {
            value = VcrImageLayerVariant3;
            return IsVcrImageLayerVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.VcrImageLayerVariant3 PickVcrImageLayerVariant3() => IsVcrImageLayerVariant3
            ? VcrImageLayerVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VcrImageLayerVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.VcrImageLayerVariant4? VcrImageLayerVariant4 { get; init; }
#else
        public global::Vercel.VcrImageLayerVariant4? VcrImageLayerVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VcrImageLayerVariant4))]
#endif
        public bool IsVcrImageLayerVariant4 => VcrImageLayerVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVcrImageLayerVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.VcrImageLayerVariant4? value)
        {
            value = VcrImageLayerVariant4;
            return IsVcrImageLayerVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.VcrImageLayerVariant4 PickVcrImageLayerVariant4() => IsVcrImageLayerVariant4
            ? VcrImageLayerVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VcrImageLayerVariant4' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VcrImageLayer(global::Vercel.VcrImageLayerVariant1 value) => new VcrImageLayer((global::Vercel.VcrImageLayerVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.VcrImageLayerVariant1?(VcrImageLayer @this) => @this.VcrImageLayerVariant1;

        /// <summary>
        ///
        /// </summary>
        public VcrImageLayer(global::Vercel.VcrImageLayerVariant1? value)
        {
            VcrImageLayerVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VcrImageLayer FromVcrImageLayerVariant1(global::Vercel.VcrImageLayerVariant1? value) => new VcrImageLayer(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VcrImageLayer(global::Vercel.VcrImageLayerVariant2 value) => new VcrImageLayer((global::Vercel.VcrImageLayerVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.VcrImageLayerVariant2?(VcrImageLayer @this) => @this.VcrImageLayerVariant2;

        /// <summary>
        ///
        /// </summary>
        public VcrImageLayer(global::Vercel.VcrImageLayerVariant2? value)
        {
            VcrImageLayerVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VcrImageLayer FromVcrImageLayerVariant2(global::Vercel.VcrImageLayerVariant2? value) => new VcrImageLayer(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VcrImageLayer(global::Vercel.VcrImageLayerVariant3 value) => new VcrImageLayer((global::Vercel.VcrImageLayerVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.VcrImageLayerVariant3?(VcrImageLayer @this) => @this.VcrImageLayerVariant3;

        /// <summary>
        ///
        /// </summary>
        public VcrImageLayer(global::Vercel.VcrImageLayerVariant3? value)
        {
            VcrImageLayerVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VcrImageLayer FromVcrImageLayerVariant3(global::Vercel.VcrImageLayerVariant3? value) => new VcrImageLayer(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VcrImageLayer(global::Vercel.VcrImageLayerVariant4 value) => new VcrImageLayer((global::Vercel.VcrImageLayerVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.VcrImageLayerVariant4?(VcrImageLayer @this) => @this.VcrImageLayerVariant4;

        /// <summary>
        ///
        /// </summary>
        public VcrImageLayer(global::Vercel.VcrImageLayerVariant4? value)
        {
            VcrImageLayerVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VcrImageLayer FromVcrImageLayerVariant4(global::Vercel.VcrImageLayerVariant4? value) => new VcrImageLayer(value);

        /// <summary>
        ///
        /// </summary>
        public VcrImageLayer(
            global::Vercel.VcrImageLayerVariant1? vcrImageLayerVariant1,
            global::Vercel.VcrImageLayerVariant2? vcrImageLayerVariant2,
            global::Vercel.VcrImageLayerVariant3? vcrImageLayerVariant3,
            global::Vercel.VcrImageLayerVariant4? vcrImageLayerVariant4
            )
        {
            VcrImageLayerVariant1 = vcrImageLayerVariant1;
            VcrImageLayerVariant2 = vcrImageLayerVariant2;
            VcrImageLayerVariant3 = vcrImageLayerVariant3;
            VcrImageLayerVariant4 = vcrImageLayerVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            VcrImageLayerVariant4 as object ??
            VcrImageLayerVariant3 as object ??
            VcrImageLayerVariant2 as object ??
            VcrImageLayerVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            VcrImageLayerVariant1?.ToString() ??
            VcrImageLayerVariant2?.ToString() ??
            VcrImageLayerVariant3?.ToString() ??
            VcrImageLayerVariant4?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsVcrImageLayerVariant1 && !IsVcrImageLayerVariant2 && !IsVcrImageLayerVariant3 && !IsVcrImageLayerVariant4 || !IsVcrImageLayerVariant1 && IsVcrImageLayerVariant2 && !IsVcrImageLayerVariant3 && !IsVcrImageLayerVariant4 || !IsVcrImageLayerVariant1 && !IsVcrImageLayerVariant2 && IsVcrImageLayerVariant3 && !IsVcrImageLayerVariant4 || !IsVcrImageLayerVariant1 && !IsVcrImageLayerVariant2 && !IsVcrImageLayerVariant3 && IsVcrImageLayerVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.VcrImageLayerVariant1, TResult>? vcrImageLayerVariant1 = null,
            global::System.Func<global::Vercel.VcrImageLayerVariant2, TResult>? vcrImageLayerVariant2 = null,
            global::System.Func<global::Vercel.VcrImageLayerVariant3, TResult>? vcrImageLayerVariant3 = null,
            global::System.Func<global::Vercel.VcrImageLayerVariant4, TResult>? vcrImageLayerVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVcrImageLayerVariant1 && vcrImageLayerVariant1 != null)
            {
                return vcrImageLayerVariant1(VcrImageLayerVariant1!);
            }
            else if (IsVcrImageLayerVariant2 && vcrImageLayerVariant2 != null)
            {
                return vcrImageLayerVariant2(VcrImageLayerVariant2!);
            }
            else if (IsVcrImageLayerVariant3 && vcrImageLayerVariant3 != null)
            {
                return vcrImageLayerVariant3(VcrImageLayerVariant3!);
            }
            else if (IsVcrImageLayerVariant4 && vcrImageLayerVariant4 != null)
            {
                return vcrImageLayerVariant4(VcrImageLayerVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.VcrImageLayerVariant1>? vcrImageLayerVariant1 = null,

            global::System.Action<global::Vercel.VcrImageLayerVariant2>? vcrImageLayerVariant2 = null,

            global::System.Action<global::Vercel.VcrImageLayerVariant3>? vcrImageLayerVariant3 = null,

            global::System.Action<global::Vercel.VcrImageLayerVariant4>? vcrImageLayerVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVcrImageLayerVariant1)
            {
                vcrImageLayerVariant1?.Invoke(VcrImageLayerVariant1!);
            }
            else if (IsVcrImageLayerVariant2)
            {
                vcrImageLayerVariant2?.Invoke(VcrImageLayerVariant2!);
            }
            else if (IsVcrImageLayerVariant3)
            {
                vcrImageLayerVariant3?.Invoke(VcrImageLayerVariant3!);
            }
            else if (IsVcrImageLayerVariant4)
            {
                vcrImageLayerVariant4?.Invoke(VcrImageLayerVariant4!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.VcrImageLayerVariant1>? vcrImageLayerVariant1 = null,
            global::System.Action<global::Vercel.VcrImageLayerVariant2>? vcrImageLayerVariant2 = null,
            global::System.Action<global::Vercel.VcrImageLayerVariant3>? vcrImageLayerVariant3 = null,
            global::System.Action<global::Vercel.VcrImageLayerVariant4>? vcrImageLayerVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVcrImageLayerVariant1)
            {
                vcrImageLayerVariant1?.Invoke(VcrImageLayerVariant1!);
            }
            else if (IsVcrImageLayerVariant2)
            {
                vcrImageLayerVariant2?.Invoke(VcrImageLayerVariant2!);
            }
            else if (IsVcrImageLayerVariant3)
            {
                vcrImageLayerVariant3?.Invoke(VcrImageLayerVariant3!);
            }
            else if (IsVcrImageLayerVariant4)
            {
                vcrImageLayerVariant4?.Invoke(VcrImageLayerVariant4!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VcrImageLayerVariant1,
                typeof(global::Vercel.VcrImageLayerVariant1),
                VcrImageLayerVariant2,
                typeof(global::Vercel.VcrImageLayerVariant2),
                VcrImageLayerVariant3,
                typeof(global::Vercel.VcrImageLayerVariant3),
                VcrImageLayerVariant4,
                typeof(global::Vercel.VcrImageLayerVariant4),
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
        public bool Equals(VcrImageLayer other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.VcrImageLayerVariant1?>.Default.Equals(VcrImageLayerVariant1, other.VcrImageLayerVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.VcrImageLayerVariant2?>.Default.Equals(VcrImageLayerVariant2, other.VcrImageLayerVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.VcrImageLayerVariant3?>.Default.Equals(VcrImageLayerVariant3, other.VcrImageLayerVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.VcrImageLayerVariant4?>.Default.Equals(VcrImageLayerVariant4, other.VcrImageLayerVariant4)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(VcrImageLayer obj1, VcrImageLayer obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VcrImageLayer>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VcrImageLayer obj1, VcrImageLayer obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VcrImageLayer o && Equals(o);
        }
    }
}
