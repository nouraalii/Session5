using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //Access Modifier : C# keyword indicate the accessibilty scope
    //1.private
    //2.private protected
    //3.protected
    //4.internal
    //5.internal protected
    //6.public

    //what can write inside the namesapse?
    //1.class
    //2.struct
    //3.interface
    //4.enum

    //Access Modifiers can use inside the namespace:
    //1.internal
    //2.public

    //What can write inside class or struct?
    //1.Attribute(Variables)
    //2.Methods(Functions)
    //3.Properties(Full property - Automatic Property - Special Property [Indexer])
    //4.Events

    //Access Modifiers can use inside the class:
    //1.private
    //2.private protected
    //3.protected
    //4.internal
    //5.internal protected
    //6.public

    //Access Modifiers can use inside the Struct:
    //1.private
    //4.internal
    //6.public

    //Default Access Modifier inside the class or struct "private"


    //Waht can write inside the interface?
    //1.signature of method(name,rteurn type,parameter)
    //2.signature of property 
    //3.default implemented method(fully Implemented Method)

    //Access Modifiers can use inside the interface:
    //1.private
    //2.private protected
    //3.protected
    //4.internal
    //5.internal protected
    //6.public

    //Default Access Modifier inside the interface "public"
    internal class TypeA
    {
        private int X;
        internal int Y;
        public int Z;
        int A;

        void func01()
        {
            TypeA typeA = new TypeA();
            typeA.X = 12;
            typeA.Y = 12;
            typeA.Z = 12;
        }
    }
}
