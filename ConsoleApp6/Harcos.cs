using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Harcos
    {


        private string nev;
        private int szint;
        private int tapasztalat;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;




        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }
        public int Sebzes { get => alapSebzes + szint; }
        public int SzintLepeshez { get => 10 + szint * 5; }
        public int MaxEletero { get => alapEletero + szint * 3; }



        public Harcos(string nev, int statuszSablon)
        {
            this.nev = nev;
            this.szint = 1;
            this.tapasztalat = 0;

            if (statuszSablon == 1)
            {
                this.alapEletero = 15;
                this.alapSebzes = 3;
            }
            else if (statuszSablon == 2)
            {
                this.alapEletero = 12;
                this.alapSebzes = 4;
            }
            else if(statuszSablon==3)
            {
                this.alapEletero = 8;
                this.alapSebzes = 5;

            }
            else
            {
                this.alapEletero = 1;
                this.alapSebzes = 1;
            }
            
        }
        public void Megkuzd()
        {
            if (eletero==0)
            {
                String.Format("hiba a karakter hpja {0}",eletero);
            }
        }
        public void Gyogyul()
        {
            if (eletero==0)
            {
                Eletero = MaxEletero;
                tapasztalat = 0;
            }
            else if(eletero!=MaxEletero)
            {
                Eletero += 3 + szint;
            }
            if (tapasztalat==SzintLepeshez)
            {
                Szint++;
            }
        }
        public string ToString()
        {
           return String.Format("{0}-LVL:{1}-EXP:{2}/{3}-HP:{4}/{5}-DMG:{6}",nev,szint,tapasztalat,SzintLepeshez,eletero,MaxEletero,Sebzes);
        }
    }
}

