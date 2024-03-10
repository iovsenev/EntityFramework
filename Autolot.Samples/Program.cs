using AutoLot.Samples;

Console.WriteLine("Fun with EFCore");

var context = new ApplicationDbContextFactory().CreateDbContext(null);
var repo = new CarRepository(context);
var cars = repo.GetAllCar();
foreach (var car in cars)
{
    Console.WriteLine($" Id: {car.Id}, Name: {car.PetName}, Color: {car.Color}");
}

var makes = repo.GetAllMake();
foreach (var make in makes)
{
    Console.WriteLine($" Id: {make.Id}, Name: {make.Name},");
}


//static void SampleSaveChanges()
//{
//    using var trans = context.Database.BeginTransaction();
//    try
//    {

//        context.SaveChanges();
//        trans.Commit();
//    }
//    catch (Exception ex)
//    {
//        trans.Rollback();
//    }
//}

