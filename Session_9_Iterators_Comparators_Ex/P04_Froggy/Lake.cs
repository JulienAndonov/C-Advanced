using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P04_Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(params int[] newStones)
        {
            this.stones = new List<int>(newStones);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i+=2)
            {
                yield return stones[i];
            }

            var lastEvenIndex = this.stones.Count % 2 == 0 ? this.stones.Count - 1 : this.stones.Count - 2;

            for (int i = lastEvenIndex; i >= 0; i-=2)
            {
                yield return stones[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
