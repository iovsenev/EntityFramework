using AutoLot.Samples;

Console.WriteLine("Fun with EFCore");

static void SampleSaveChanges()
{
    var context = new ApplicationDbContextFactory().CreateDbContext(null);
    using var trans = context.Database.BeginTransaction();
    try
    {

    context.SaveChanges();
        trans.Commit();
    }
    catch (Exception ex)
    {
        trans.Rollback();
    }
}

