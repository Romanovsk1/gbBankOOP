using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4._1
{
    public class Building
    {
        /// <summary>
        /// Счетчик уникальных номеров зданий
        /// </summary>
        private static uint _counter = 1;

        /// <summary>
        /// Уникальный номер здания
        /// </summary>
        private uint _idBuilding;

        /// <summary>
        /// Высота
        /// </summary>
        private float _height;

        /// <summary>
        /// Этажность
        /// </summary>
        private short _floor;

        /// <summary>
        /// Количество квартир
        /// </summary>
        private uint _flat;

        /// <summary>
        /// Количество подъездов
        /// </summary>
        private uint _entrance;



        public void Add(float height, short floor, uint flat, uint entrance)
        {
            _idBuilding = CounterPlus(_counter);

            _height = height;

            _floor = floor;

            _flat = flat;

            _entrance = entrance;
        }
        public void Add(uint apartmentsOnTheFloor, short floor, uint entrance)
        {
            _idBuilding = _counter++;

            _floor = floor;

            _entrance = entrance;

            _flat = apartmentsOnTheFloor * (uint)_floor * _entrance;

            BuildingHeight(_floor);
        }
        public void BuildingHeight(short floor)
        {
            float basement = 2.1F;

            float attic = 4.2F;

            _floor = floor;

            _height = (floor * 3) + basement + attic;
        }

        public void Print()
        {
            Console.WriteLine($"Уникальный номер здания: {_idBuilding}; высота: {_height}; этажность: {_floor}; количество квартир: {_flat}; количества подъездов: {_entrance};");
        }

        public uint CounterPlus(uint counter)
        {
            return counter++;
        }
    }
}
