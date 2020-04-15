using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            TableManager tM = new TableManager("dbo.students");
            tM.AddColumns("ID", "Name", "Surname", "PhoneNumber", "HomeAdress");
            tM.AddRow("1", "Амирхонов", "Масъуд", "+992938851985", "Бинокорон 22/35");
            tM.AddRow("2", "Ибрагимов", "Мансур", "+992112200202", "Бинокорон 22/15");
            tM.AddRow("3", "Амирхонова", "Марьям", "+992502028046", "Бинокорон 22/18");
            tM.AddRow("4", "Амирхонов", "Башоратулло", "+992988843313", "Бинокорон 22/19");
            tM.Output();
        }
    }
}
