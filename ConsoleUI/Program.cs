
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System.Reflection.PortableExecutable;

MachineTest();

static void MachineTest()
{
   MachineManager machineManager=new MachineManager(new EfMachineDal());

   foreach(var entity in machineManager.GetAllById(1))
    {
        Console.WriteLine(entity);
    }
}