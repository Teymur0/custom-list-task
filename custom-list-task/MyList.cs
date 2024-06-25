using System.Collections;

namespace custom_list_task
{
    internal class MyList : IEnumerable
    {
        int[] myList = new int[0];


        public MyList()
        {

        }

        public int this[int index]
        {

            get => myList[index];
            set => myList[index] = value;
        }

        #region Add item to array
        public void Add(int el)
        {
            Array.Resize(ref myList, el);
            myList[myList.Length - 1] = el;

        }
        #endregion

        #region Element contains in array
        public bool Contains(int el)
        {

            for (int i = 0; i < myList.Length; i++)
            {

                if (myList[i] == el)
                {
                    return true;
                }

            }

            return false;
        }
        #endregion

        #region Ienumerator
        public IEnumerator GetEnumerator()
        {

            foreach (var item in myList)
            {
                yield return item;
            }
            //other way
            // return myList.GetEnumerator();
        }
        #endregion

        #region Index of element
        public int IndexOf(int el)
        {
            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i] == el)
                {
                    return i;
                }

            }

            return -1;
        }
        #endregion

        #region Reverse array
        public void Reverse()
        {
            int[] temporary = new int[myList.Length];
            int idx = 0;
            for (int i = temporary.Length - 1; i >= 0; i--)
            {

                temporary[idx] = myList[i];
                idx++;

            }

            myList = temporary;

        }
        #endregion

        #region Remove element from array

        public void Remove(int el)
        {

            int[] temporaryArr = new int[myList.Length - 1];
            int idx = 0;

            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i] != el)
                {
                    temporaryArr[idx] = myList[i];
                    idx++;

                }
            }

            myList = temporaryArr;
        }
        #endregion

        #region Print info
        public void ShowInfo()
        {
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

        }
        #endregion

    }
}
