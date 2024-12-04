using System;

namespace Tumakov_Labs
{
    class Building
    {
        /// <summary>
        /// Статическая переменная для хранения последнего использованного уникального номера здания
        /// </summary>
        private static ulong lastBuildingNumber = 1;
        /// <summary>
        /// Уникальный номер здания
        /// </summary>
        private ulong buildingNumber;
        /// <summary>
        /// Высота здания в метрах
        /// </summary>
        private double height; 
        /// <summary>
        /// Этажность
        /// </summary>
        private int floors; 
        /// <summary>
        /// Количество квартир
        /// </summary>
        private int apartments; 
        /// <summary>
        /// Количество подъездов
        /// </summary>
        private int entrances; 
        public Building(double height, int floors, int apartments, int entrances)
        {
            this.buildingNumber = GenerateUniqueBuildingNumber();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }
        // Метод для генерации уникального номера здания
        private static ulong GenerateUniqueBuildingNumber()
        {
            return lastBuildingNumber++;
        }
        public ulong GetBuildingNumber()
        {
            return buildingNumber;
        }
        public double GetHeight()
        {
            return height;
        }
        public int GetFloors()
        {
            return floors;
        }
        public int GetApartments()
        {
            return apartments;
        }
        public int GetEntrances()
        {
            return entrances;
        }
        // Метод для вычисления высоты этажа
        public double CalculateFloorHeight()
        {
            return height / floors;
        }
        // Метод для вычисления количества квартир в подъезде
        public int CalculateApartmentsPerEntrance()
        {
            return apartments / entrances;
        }
        // Метод для вычисления количества квартир на этаже
        public int CalculateApartmentsPerFloor()
        {
            return apartments / floors;
        }
        // Метод для вывода информации о здании
        public void PrintBuildingInfo()
        {
            Console.WriteLine($"Уникальный номер здания: {buildingNumber}");
            Console.WriteLine($"Высота здания: {height} метров");
            Console.WriteLine($"Этажность: {floors} этажей");
            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entrances}");
            Console.WriteLine($"Высота этажа: {CalculateFloorHeight():N2} метров");
            Console.WriteLine($"Квартир в подъезде: {CalculateApartmentsPerEntrance()}");
            Console.WriteLine($"Квартир на этаже: {CalculateApartmentsPerFloor()}");
            Console.WriteLine();
        }
    }
}
