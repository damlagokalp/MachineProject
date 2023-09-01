
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Reflection.PortableExecutable;
using DataAccess.Concrete.InMemory;
using Business.Concrete;
using Machine = Entities.Concrete.Machine;



//DATA CREATION
CreateMachineOfProducerAndBrands();
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
static void CreateDataOfMachines()
{
    MachineManager machineManager1=new MachineManager(new EfMachineDal());
    machineManager1.AddMachine(new Machine { MachineName = "A6", BrandId = 10, ProducerName = "A üreticisi", Description = "A6 Housing" });
    machineManager1.AddMachine(new Machine { MachineName = "A4", BrandId = 20, ProducerName = "B üreticisi", Description = "A4 Cylinder" });
    machineManager1.AddMachine(new Machine { MachineName = "A10", BrandId =30, ProducerName = "C üreticisi", Description = "A10 Drive Shaft" });
    machineManager1.AddMachine(new Machine { MachineName = "A2", BrandId = 40, ProducerName = "D üreticisi", Description = "A2 Control Lens" });
    machineManager1.AddMachine(new Machine { MachineName = "MC", BrandId = 50, ProducerName = "E üreticisi", Description = "MC IBV" });
}

static void CreateMachineOfProducerAndBrands()
{
    Console.WriteLine("-------Markalar eklendi----------");
    BrandManager brandManager = new BrandManager(new EfBrandDal());
    brandManager.Add(new Brand { BrandId = 1, BrandName = "X" });
    brandManager.Add(new Brand { BrandId = 2, BrandName = "Y" });
    brandManager.Add(new Brand { BrandId = 3, BrandName = "Z" });
    brandManager.Add(new Brand { BrandId = 4, BrandName = "W" });
    brandManager.Add(new Brand { BrandId = 5, BrandName = "Q" });

    Console.WriteLine("-----Üreticiler eklendi--------");
    ProducerManager producerManager = new ProducerManager(new EfProducerDal());
    producerManager.Add(new Producer { ProducerName = "A üreticisi" });
    producerManager.Add(new Producer {  ProducerName = "B üreticisi" });
    producerManager.Add(new Producer {  ProducerName = "C üreticisi" });
    producerManager.Add(new Producer {  ProducerName = "D üreticisi" });
    producerManager.Add(new Producer { ProducerName = "E üreticisi" });
}

static void MachineDeleteTest()
{
    MachineManager delete = new MachineManager(new EfMachineDal());
    delete.DeleteMachine(new Machine { MachineId = 1 });
}

static void UpdateMachineTest()
{
    MachineManager update = new MachineManager(new EfMachineDal());
    update.UpdateMachine(new Machine { MachineId = 5, BrandId=1, MachineName="A6 ",Description="A6 Cylinder",ProducerName="F üreticisi"}); 
}