using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    namespace DepositoGenerico
    {
        public class Storage<T>
        {

            #region Fields

            private int _length;

            private List<T> _list;

            #endregion


            #region Methods

            public bool Add(T that)
            {
                bool returnAux = false;
                int i = 0;


                if ((object)that == null || this._length <= this._list.Count) return returnAux;


                for (i = 0; i < this._list.Count; i++)
                {

                    if (this._list[i].Equals(that) == true) break;

                }

                if (i == this._list.Count)
                {
                    this._list.Add(that);
                    returnAux = true;
                }

                return returnAux;
            }

            private int GetIndex(T that)
            {
                int returnAux = 0;

                foreach (T element in this._list)
                {

                    if (element.Equals(that) == true) break;


                    returnAux++;
                }

                return returnAux;

            }

            public bool remove(T that)
            {
                bool returnAux = false;
                int index = this.GetIndex(that);

                if (index < this._list.Count)
                {

                    this._list.RemoveAt(index);
                    returnAux = true;
                }

                return returnAux;
            }

            public override string ToString()
            {
                string toString = base.ToString() + "\n";

                foreach (T element in this._list)
                {
                    toString += element.ToString();
                }

                return toString;
            }

            #region Constructor

            public Storage(int length)
            {
                this._length = length;

                this._list = new List<T>();


            }

            #endregion

            #endregion

        }
    }
}
