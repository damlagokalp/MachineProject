
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Reflection.PortableExecutable;
using DataAccess.Concrete.InMemory;
using Business.Concrete;



//DATA CREATION
//CreateMachineOfPRoducerAndBrands();
//CreateDataOfMachines();

//------------------------------------------------

//MachineTest();
//UpdateMachineTest();
//MachineDeleteTest();
MachineManager machineManager = new MachineManager(new EfMachineDal());
foreach (var machine in machineManager.GetMachineDetails().Data)
{
    Console.WriteLine("Id: {0} Machine: {1} Brand: {2} Producer: {3}",machine.MachineId,machine.MachineName);
}

static void MachineTest()
{
   MachineManager machineManager=new MachineManager(new EfMachineDal());
    foreach(var machine in machineManager.GetAll().Data)
    {
        Console.WriteLine("{0} : {1}",machine.MachineId ,machine.MachineName);
    }

    
}

//static void MachineDeleteTest()
//{
//    MachineManager delete = new MachineManager(EfMachineDal());
//    delete.DeleteMachine(new
//        +93,0);
//}