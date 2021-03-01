using System;
using ConsoleApp2.AFeladatsor;
using ConsoleApp2.BFeladatsor;
using ConsoleApp2.CFeladatsor;
using ConsoleApp2.Orai_Magyarazatok;
using ConsoleApp2.HeroGameDir;
using ConsoleApp2.Orai_Dolgozat;
using ConsoleApp2.File_Handling;

namespace ConsoleApp2
{
    class Program
    {
        static elsoFeladat _feladatok = new elsoFeladat();
        static masodikfeladat _feladatok2 = new masodikfeladat();
        static harmadikfeladat _feladatok3 = new harmadikfeladat();
        static tombok _oraifeladatok = new tombok();
        static heroGame _hero = new heroGame();
        static throwaway _test = new throwaway();
        static oraidolgozat _od = new oraidolgozat();
        static listak _lista = new listak();
        static fileHandling _fileHandling = new fileHandling();


        static void Main(string[] args)
        {
            /*******************Hero Game*******************/
            // _hero.mainGamePlay();
            /**********Tömbök**********/
            //_od.oraiFeladat();
            /*********listák*********/
            //_lista.lista1();
            //_lista.lista2();
            //_lista.lista3();
            //_fileHandling.fileKezeles();
            //_fileHandling.fileKezeles2();
            _fileHandling.fileKezeles3();









            // A. Egyszerű adat ki- és bevitel 
            /*
            _feladatok.FeladatA1();
            _feladatok.FeladatA2();
            _feladatok.FeladatA3();
            _feladatok.FeladatA4();
            _feladatok.FeladatA5();
            _feladatok.FeladatA6();
            _feladatok.FeladatA7();
            _feladatok.FeladatA8();
            _feladatok.FeladatA9();
            _feladatok.FeladatA10();
            _feladatok.FeladatA11();
            _feladatok.FeladatA12();
            _feladatok.FeladatA13();
            _feladatok.FeladatA14();
            _feladatok.FeladatA15();
            */


            // B. Szelekciók 
            /*_feladatok2.FeladatB1();
            _feladatok2.FeladatB2();
            _feladatok2.FeladatB3();
            _feladatok2.FeladatB4();
            _feladatok2.FeladatB5();
            _feladatok2.FeladatB6();
            _feladatok2.FeladatB7();
            _feladatok2.FeladatB8();
            _feladatok2.FeladatB9();
            _feladatok2.FeladatB10();
            _feladatok2.FeladatB11();
            _feladatok2.FeladatB12();
            _feladatok2.FeladatB13();
            */

            // C. Ciklusok 
            /* 
             _feladatok3.FeladatC1();
             _feladatok3.FeladatC2();
            _feladatok3.FeladatC3();
            _feladatok3.FeladatC4();
            _feladatok3.FeladatC5();
            _feladatok3.FeladatC6();
            _feladatok3.FeladatC7();
            _feladatok3.FeladatC8();
            _feladatok3.FeladatC9();
            _feladatok3.FeladatC10();
            _feladatok3.FeladatC11();


            _feladatok3.FeladatC14();
            _feladatok3.FeladatC15();
            _feladatok3.FeladatC16();
            _feladatok3.FeladatC17();
            */

            //_feladatok3.FeladatC12();
            //_feladatok3.FeladatC13();
            //_feladatok3.FeladatC18();

            /* Orai feladatok 
             _oraifeladatok.tombokFeladat();
             
             
             
             
             */

        }
    }
}
