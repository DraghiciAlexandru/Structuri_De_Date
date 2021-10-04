using System;
using System.Collections.Generic;
using System.Text;

namespace Structuri_De_Date_Generice
{
    class SimpleHashTable<K ,V>
    {
        private Stored<K, V>[] hashtable;
        

        public SimpleHashTable()
        {
            hashtable = new Stored<K, V>[10];
        }

        //functia hash

        private int hashKey(K key)
        {
            return Math.Abs( key.GetHashCode()) % hashtable.Length;
        }

        public void put(K key ,V value)
        {

            int pozitie = hashKey(key);

            if (ocupied(pozitie))
            {

                int stop = pozitie;

                if (pozitie == hashtable.Length - 1)
                {
                    pozitie = 0;
                }
                else
                {
                    pozitie++;
                }

                while (ocupied(pozitie) && pozitie != stop)
                {
                    pozitie = (pozitie + 1) % hashtable.Length;
                }

            }

            if (ocupied(pozitie))
            {
                Console.WriteLine("Nu avem loc");
            }
            else
            {
                hashtable[pozitie] = new Stored<K, V>();
                hashtable[pozitie].Key = key;
                hashtable[pozitie].Value = value;
            }

        }


        private bool ocupied(int index)
        {
            return hashtable[index] != null;
        }


        private int findKey(K key)
        {
            int pozitie = hashKey(key);

            if (hashtable[pozitie] != null && hashtable[pozitie].Key.Equals(key))
            {
                return pozitie;
            }
            

            int stop = pozitie;

            if (pozitie == hashtable.Length - 1)
            {
                pozitie = 0;
            }
            else
            {
                pozitie++;
            }


            while (pozitie != stop && hashtable[pozitie] != null && !hashtable[pozitie].Key.Equals(key)) 
            {
                
                pozitie = (pozitie + 1) % hashtable.Length;
            }


            if (hashtable[pozitie] != null && hashtable[pozitie].Key.Equals(key)) 
            {

                return pozitie;
            }
            else
            {
                return -1;
            }
           
        }


        public V get(K key)
        {

            int pozigtie = findKey(key);

            Console.WriteLine(pozigtie);

            if (pozigtie != -1)
            {
                return hashtable[pozigtie].Value;
            }

            return default(V);
        }


        public override string ToString()
        {
            String text = "";

            foreach(Stored<K,V> stored in hashtable)
            {
                if (stored != null)
                    text += stored.Key.ToString() + Environment.NewLine + stored.Value.ToString() + Environment.NewLine + Environment.NewLine;
            }

            return text;

        }

        public void remove(K key)
        {
            Stored<K, V>[] vechi = hashtable;

            if (findKey(key) != -1)
            {
                hashtable[findKey(key)] = null;
            }


            hashtable = new Stored<K, V>[10];

            for (int i = 0; i < 10; i++) 
            {
                if (vechi[i] != null) 
                {
                    put(vechi[i].Key, vechi[i].Value);
                }
            }
            
        }
    }
}
