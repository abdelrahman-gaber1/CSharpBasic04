using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic04.Interface_Example2
{
    internal class Airplane : Vichle, IFlyable, IMovable
    {
        #region Explicitly

        //void IFlyable.Backward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMovable.Backward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFlyable.Forward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMovable.Forward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFlyable.Left()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMovable.Left()
        //{
        //    throw new NotImplementedException();
        //}

        //void IFlyable.Right()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMovable.Right()
        //{
        //    throw new NotImplementedException();
        //}
        #endregion

        #region Implicitly

        public void Backward()
        {
            Console.WriteLine("Backward Implicitly");
        }

        public void Forward()
        {
            Console.WriteLine("Forward Implicitly");
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
        #endregion  
    }
}
