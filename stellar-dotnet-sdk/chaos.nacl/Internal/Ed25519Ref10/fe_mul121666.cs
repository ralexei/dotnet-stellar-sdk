﻿namespace stellar_dotnet_sdk.chaos.nacl.Internal.Ed25519Ref10
{
    internal static partial class FieldOperations
    {
        /*
        h = f * 121666
        Can overlap h with f.

        Preconditions:
           |f| bounded by 1.1*2^26,1.1*2^25,1.1*2^26,1.1*2^25,etc.

        Postconditions:
           |h| bounded by 1.1*2^25,1.1*2^24,1.1*2^25,1.1*2^24,etc.
        */

        public static void fe_mul121666(out FieldElement h, ref FieldElement f)
        {
            var f0 = f.x0;
            var f1 = f.x1;
            var f2 = f.x2;
            var f3 = f.x3;
            var f4 = f.x4;
            var f5 = f.x5;
            var f6 = f.x6;
            var f7 = f.x7;
            var f8 = f.x8;
            var f9 = f.x9;
            var h0 = f0 * (long) 121666;
            var h1 = f1 * (long) 121666;
            var h2 = f2 * (long) 121666;
            var h3 = f3 * (long) 121666;
            var h4 = f4 * (long) 121666;
            var h5 = f5 * (long) 121666;
            var h6 = f6 * (long) 121666;
            var h7 = f7 * (long) 121666;
            var h8 = f8 * (long) 121666;
            var h9 = f9 * (long) 121666;

            var carry9 = (h9 + (1 << 24)) >> 25;
            h0 += carry9 * 19;
            h9 -= carry9 << 25;
            var carry1 = (h1 + (1 << 24)) >> 25;
            h2 += carry1;
            h1 -= carry1 << 25;
            var carry3 = (h3 + (1 << 24)) >> 25;
            h4 += carry3;
            h3 -= carry3 << 25;
            var carry5 = (h5 + (1 << 24)) >> 25;
            h6 += carry5;
            h5 -= carry5 << 25;
            var carry7 = (h7 + (1 << 24)) >> 25;
            h8 += carry7;
            h7 -= carry7 << 25;

            var carry0 = (h0 + (1 << 25)) >> 26;
            h1 += carry0;
            h0 -= carry0 << 26;
            var carry2 = (h2 + (1 << 25)) >> 26;
            h3 += carry2;
            h2 -= carry2 << 26;
            var carry4 = (h4 + (1 << 25)) >> 26;
            h5 += carry4;
            h4 -= carry4 << 26;
            var carry6 = (h6 + (1 << 25)) >> 26;
            h7 += carry6;
            h6 -= carry6 << 26;
            var carry8 = (h8 + (1 << 25)) >> 26;
            h9 += carry8;
            h8 -= carry8 << 26;

            h.x0 = (int) h0;
            h.x1 = (int) h1;
            h.x2 = (int) h2;
            h.x3 = (int) h3;
            h.x4 = (int) h4;
            h.x5 = (int) h5;
            h.x6 = (int) h6;
            h.x7 = (int) h7;
            h.x8 = (int) h8;
            h.x9 = (int) h9;
        }
    }
}