using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core.machine.drivers;

namespace core.machine.components
{

    public class BaseObject
    {
        public int Id;
        public int Index;

        public string Name;
    }


    public abstract class Driver : BaseObject, IDriver
    {
        public Driver(int id, int index, string name)
        {
            Id = id;
            Index = index;
            Name = name;
        }

        public void Initialize(params object[] configs)
        {
        }

        public void Terminate()
        {
        }

        public void Update()
        {
        }

        public int GetDi(int port)
        {
            return 0;
        }

        public void SetDi(int port, int status)
        {
        }

        public int GetDo(int port)
        {
            return 0;
        }

        public void SetDo(int port, int status)
        {
        }
    }


    public class Di : BaseObject
    {
        private Driver _driver;
        public Di(Driver driver, int id, int index, string name)
        {
            _driver = driver;
            Id = id;
            Index = index;
            Name = name;
        }

        public int Set(int status)
        {
            _driver.SetDi(Index, status);
            return 0;
        }

        public int Get()
        {
            return _driver.GetDi(Index);
        }
    }


    public class Do : BaseObject
    {
        private Driver _driver;
        public Do(Driver driver, int id, int index, string name)
        {
            _driver = driver;
            Id = id;
            Index = index;
            Name = name;
        }

        public int Set(int status)
        {
            _driver.SetDo(Index, status);
            return 0;
        }
        public int Get()
        {
            return _driver.GetDo(Index);
        }


    }



  
    public class RotAxis : BaseObject
    {
        public RotAxis(Driver driver, int id, int index, int ratio)
        {

        }





    }


    public class TransAxis : BaseObject
    {
        public TransAxis(Driver driver, int id, int index)
        {

        }


    }

}
