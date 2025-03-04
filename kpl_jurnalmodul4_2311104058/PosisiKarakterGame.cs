using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpl_jurnalmodul4_2311104058
{
    public enum State
    {
        Berdiri,
        Jongkok,
        Tengkurap,
        Terbang
    }

    public class PosisiKarakterGame
    {
        private State currentState;
        private int nim;

        public PosisiKarakterGame(int nim)
        {
            this.nim = nim;
            currentState = State.Berdiri;
        }

        public void TombolS()
        {
            Console.WriteLine("Sebelum TombolS: " + currentState);
            if (nim % 3 == 0)
                Console.WriteLine("tombol arah bawah ditekan");

            switch (currentState)
            {
                case State.Berdiri:
                    currentState = State.Jongkok;
                    break;
                case State.Jongkok:
                    currentState = State.Tengkurap;
                    if (nim % 3 == 1)
                        Console.WriteLine("posisi istirahat");
                    break;
                case State.Terbang:
                    currentState = State.Jongkok;
                    if (nim % 3 == 2)
                        Console.WriteLine("posisi landing");
                    break;
            }
            Console.WriteLine("Sesudah TombolS: " + currentState);
        }

        public void TombolW()
        {
            Console.WriteLine("Sebelum TombolW: " + currentState);
            if (nim % 3 == 0)
                Console.WriteLine("tombola rah atas ditekan");

            switch (currentState)
            {
                case State.Jongkok:
                    currentState = State.Berdiri;
                    if (nim % 3 == 1)
                        Console.WriteLine("posisi standby");
                    break;
                case State.Berdiri:
                    currentState = State.Terbang;
                    if (nim % 3 == 2)
                        Console.WriteLine("posisi take off");
                    break;
            }
            Console.WriteLine("Sesudah TombolW: " + currentState);
        }

        public void TombolX()
        {
            Console.WriteLine("Sebelum TombolX: " + currentState);
            if (currentState == State.Jongkok)
            {
                currentState = State.Terbang;
            }
            Console.WriteLine("Sesudah TombolX: " + currentState);
        }

        public void PrintState()
        {
            Console.WriteLine("Posisi saat ini: " + currentState);
        }
    }
}