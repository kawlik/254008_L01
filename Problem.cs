using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _254008_L01
{
    internal class Item
    {
        public int v;
        public int w;

        public Item(int v, int w)
        {
            this.v = v;
            this.w = w;
        }
    }

    public class Problem
    {
        private List<Item> items;

        public Problem(int seed, int numItems)
        {
            Random r = new Random(seed);
            this.items = new List<Item>(numItems);
            for (int i = 0; i < numItems; i++)
            {
                items.Add(new Item(r.Next(29) + 1, r.Next(29) + 1));
            }
        }

        public string solveFor(int maxWeight)
        {
            int value = 0;
            int weight = 0;

            items.Sort((p, q) => (q.v / q.w).CompareTo(p.v / p.w));

            string result = "";

            for( int i = 0; i < items.Count; i++)
            {
                //  weight can not be grater than max weight
                if (weight == maxWeight) break;

                //  current item can not be grater than max weight
                if (weight + items[i].w > maxWeight) continue;

                //  add item to collection
                value += items[i].v;
                weight += items[i].w;
                result += i + 1 + ": [ v: " + items[i].v + " | w: " + items[i].w + " ]\n";
            }


            return result;
        }

        public override string ToString()
        {
            string result = "";

            for(int i = 0; i < items.Count; i++)
            {
                result += "[v: " + items[i].v + " | w: " + items[i].w + " ]" + (( i + 1 ) % 5 == 0 ? "\n" : " " );
            }


            return result;
        }
    }
}
