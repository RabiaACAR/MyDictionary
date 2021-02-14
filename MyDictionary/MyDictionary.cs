using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tx, Ty>
    {
        Tx[] keys; //Tx türünde keys dizisi
        Ty[] values;//Ty türünde values dizi

        public MyDictionary()
        {
            keys = new Tx[0]; //MyDictionary sınıfı newlendiğinde keys dizisi için bir tane adres oluşturacak.
            values = new Ty[0];//MyDictionary sınıfı newlendiğinde values dizisi için bir tane adres oluşturacak.
        }

        public void Add(Tx key, Ty value)
        {
            Tx[] tempKeyArray = keys; //keys dizisi tempKeyArray dizisine aatandı.
            Ty[] tempValueArray = values; // values dizisi tempValueArray dizisine atandı.

            keys = new Tx[keys.Length + 1];
            values = new Ty[values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
                values[i] = tempValueArray[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public int Length
        {
            get { return values.Length; }
        }
        public Tx[] Anahtar
        { get { return keys; } }

        public Ty[] Deger
        { get { return values; } }
    }
}
