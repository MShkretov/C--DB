using Hospital.Data;

var context = new HospitalContext();

if (!context.Database.EnsureCreated())
{
    Console.WriteLine("Database created successfully");
    return;
}
