using System;
using System.Collections.Generic;
using System.Linq;

namespace ZeroToTwelve
{
    public class ProblemSolver
    {
        public List<int[]> Answers { get; private set; }
        public string AnswersHeader { get; private set; }

        private int integersMaxIndex;
        private int plonkAbsoluteMaxIndex;
        public long Count;
        private int[] integers;
        private int[] plonkIntegersInMe;

        public int Z;
        public int E;
        public int R;
        public int O;
        public int N;
        public int T;
        public int W;
        public int H;
        public int F;
        public int U;
        public int I;
        public int V;
        public int S;
        public int X;
        public int G;
        public int L;

        public ProblemSolver()
        {
            this.Answers = new List<int[]>();
            this.AnswersHeader = "O,N,E,I,T,W,L,V,S,F,X,U,R,Z,H,G";
            this.integersMaxIndex = 40;
            this.Count = 0;

            this.integers = new int[this.integersMaxIndex + 1];
            this.plonkIntegersInMe = new int[16]; //Here
            this.plonkAbsoluteMaxIndex = this.plonkIntegersInMe.Length - 1;

            for (int i = 0; i <= this.integersMaxIndex; i++)
            {
                this.integers[i] = i - (this.integersMaxIndex  / 2);
            }

            this.ClearArrayFromIndex(0);
        }

        public enum Level //Here
        {
            ONE,
            ONEI,
            ONEIT,
            ONEITW,
            ONEITWLV,
            ONEITWLVS,
            ONEITWLVSF,
            ONEITWLVSFX,
            ONEITWLVSFXUR,
            ONEITWLVSFXURZ,
            ONEITWLVSFXURZH,
            ONEITWLVSFXURZHG,
            Finished
        }

        private void ClearArrayFromIndex(int index)
        {
            for (int i = index; i < this.plonkIntegersInMe.Length; i++)
            {
                this.plonkIntegersInMe[i] = -999;
            }
        }

        private int SetLevel(Level level) //Here
        {
            var plonkIntegersInMeMaxIndex = 0;
            switch (level)
            {
                case Level.ONE:
                    plonkIntegersInMeMaxIndex = 2;
                    break;
                case Level.ONEI:
                    plonkIntegersInMeMaxIndex = 3;
                    break;
                case Level.ONEIT:
                    plonkIntegersInMeMaxIndex = 4;
                    break;
                case Level.ONEITW:
                    plonkIntegersInMeMaxIndex = 5;
                    break;
                case Level.ONEITWLV:
                    plonkIntegersInMeMaxIndex = 7;
                    break;
                case Level.ONEITWLVS:
                    plonkIntegersInMeMaxIndex = 8;
                    break;
                case Level.ONEITWLVSF:
                    plonkIntegersInMeMaxIndex = 9;
                    break;
                case Level.ONEITWLVSFX:
                    plonkIntegersInMeMaxIndex = 10;
                    break;
                case Level.ONEITWLVSFXUR:
                    plonkIntegersInMeMaxIndex = 12;
                    break;
                case Level.ONEITWLVSFXURZ:
                    plonkIntegersInMeMaxIndex = 13;
                    break;
                case Level.ONEITWLVSFXURZH:
                    plonkIntegersInMeMaxIndex = 14;
                    break;
                case Level.ONEITWLVSFXURZHG:
                    plonkIntegersInMeMaxIndex = 15;
                    break;
            }

            this.ClearArrayFromIndex(plonkIntegersInMeMaxIndex + 1);

            return plonkIntegersInMeMaxIndex;
        }

        private void Display() //Here
        {
            Console.WriteLine("{0} {1} - {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}",
                ++Count,
                "",
                this.O,
                this.N,
                this.E,
                this.I,
                this.T,
                this.W,
                this.L,
                this.V,
                this.S,
                this.F,
                this.X,
                this.U,
                this.R,
                this.Z,
                this.H,
                this.G
                );
        }

        private void PopulateIntegers(int[] ints, int maxIndex) //Here
        {
            O = ints[0];
            N = ints[1];
            E = ints[2];
            if (maxIndex == 2) return;
            I = ints[3];
            if (maxIndex == 3) return;
            T = ints[4];
            if (maxIndex == 4) return;
            W = ints[5];
            if (maxIndex == 5) return;
            L = ints[6];
            V = ints[7];
            if (maxIndex == 7) return;
            S = ints[8];
            if (maxIndex == 8) return;
            F = ints[9];
            if (maxIndex == 9) return;
            X = ints[10];
            if (maxIndex == 10) return;
            U = ints[11];
            R = ints[12];
            if (maxIndex == 12) return;
            Z = ints[13];
            if (maxIndex == 13) return;
            H = ints[14];
            if (maxIndex == 14) return;
            G = ints[15];
        }

        private bool Calculate(Level level, int plonkIntegersInMeMaxIndex)
        {
            this.PopulateIntegers(this.plonkIntegersInMe, plonkIntegersInMeMaxIndex);

            switch (level)
            {
                case Level.ONE:
                    return O + N + E == 1;
                case Level.ONEI:
                    return N + I + N + E == 9;
                case Level.ONEIT:
                    return T + E + N == 10;
                case Level.ONEITW:
                    return T + W + O == 2;
                case Level.ONEITWLV:
                    return E + L + E + V + E + N == 11 && T + W + E + L + V + E == 12;
                case Level.ONEITWLVS:
                    return S + E + V + E + N == 7;
                case Level.ONEITWLVSF:
                    return F + I + V + E == 5;
                case Level.ONEITWLVSFX:
                    return S + I + X == 6;
                case Level.ONEITWLVSFXUR:
                    return F + O + U + R == 4;
                case Level.ONEITWLVSFXURZ:
                    return Z + E + R + O == 0;
                case Level.ONEITWLVSFXURZH:
                    return T + H + R + E + E == 3;
                case Level.ONEITWLVSFXURZHG:
                    return E + I + G + H + T == 8;

                default:
                    return false;
            }
        }

        public void DoIt(int currentIndex, Level level)
        {
            var plonkIntegersInMeMaxIndex = SetLevel(level);

            for (int i = 0; i <= this.integersMaxIndex; ++i)
            {
                if (!this.plonkIntegersInMe.Contains(this.integers[i]))
                {
                    this.plonkIntegersInMe[currentIndex] = this.integers[i];

                    if (currentIndex != plonkIntegersInMeMaxIndex)
                    {
                        this.DoIt(currentIndex + 1, level);
                        this.plonkIntegersInMe[currentIndex + 1] = -999;
                    }
                    else
                    {
                        if (this.Calculate(level, plonkIntegersInMeMaxIndex))
                        {
                            if (currentIndex < this.plonkAbsoluteMaxIndex)
                            {
                                this.DoIt(currentIndex + 1, level + 1);
                            }
                            else
                            {
                                this.Display();
                                var answer = new int[16];
                                Array.Copy(this.plonkIntegersInMe, answer, 16);
                                this.Answers.Add(answer);
                            }
                        }
                    }
                }
            }
        }

    }
}



