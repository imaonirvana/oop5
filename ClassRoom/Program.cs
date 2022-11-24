namespace ClassRoom;

class Program
{
    static void Main()
    {
        var classRoom = new ClassRoom(new BadPupil(), new GoodPupil(), new ExcelentPupil());
        
        classRoom.GetMetrics();
    }
}