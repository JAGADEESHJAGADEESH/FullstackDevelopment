using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.DesignPatterns.Singleton
{
    public sealed class Singleton1
    {
        private Singleton1() { }
        private static Singleton1 instance = null;

        private static readonly object lockobj = new object ();
        private static Singleton1 instance1 = null;
        public static Singleton1 Instance1
        {
            get
            {
                lock (lockobj)
                    {
                        if (instance1 == null)
                        {
                            instance1 = new Singleton1();
                        }
                        return instance;
                    }
            }
        }
        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton1();
                }
                return instance;
            }
        }
    }
}
